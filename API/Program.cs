
using Domain.DTO;
using Infrastructure.SQL.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Serilog.Context;
using System.Text;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddOpenApi();
            //  builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            builder.Services.AddAuthentication(IISDefaults.AuthenticationScheme);
            builder.Services.AddAuthentication(HttpSysDefaults.AuthenticationScheme);


            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {

                var audienceConfig = builder.Configuration.GetSection("Audience");
                var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(audienceConfig["Secret"]));

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = signingKey,
                    ValidateIssuer = true,
                    ValidIssuer = audienceConfig["Iss"],
                    ValidateAudience = true,
                    ValidAudience = audienceConfig["Aud"],
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                    RequireExpirationTime = true

                };
            });

            builder.Services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = (context) =>
                {
                    var errors = context.ModelState.Values.SelectMany(x => x.Errors.Select(e => new ErrorMessage() { error = e.ErrorMessage })).ToList();

                    var result = new ServiceResponse
                    {
                        success = false,
                        msg = "Validation Errors",
                        errorlst = errors
                    };

                    return new BadRequestObjectResult(result);
                };
            });

            var connectionString = builder.Configuration.GetConnectionString("DotNetCoreConnection");
            builder.Services.AddDbContext<DSDBContext>(d => d.UseSqlServer(connectionString), ServiceLifetime.Scoped);
            builder.Services.AddDbContext<DSDBContext>(options =>
            options.UseSqlServer(connectionString, sqlServerOptions => sqlServerOptions.CommandTimeout(90)));
            // services.AddAutoMapper(typeof(Mapping));
            builder.Services.AddLogging();
            var dependancy = new DependancyConfig.DependancyConfig(builder.Services, builder.Configuration);
            dependancy.ConfigureServices();

            builder.Services.AddAuthorization();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwaggerUI(option =>
                {
                    option.SwaggerEndpoint("/openapi/v1.json", "version v1");
                });
            }
            //  app.UseRouting();
            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.Use(async (httpContext, next) =>
            {
                var userName = httpContext.User.Identity.IsAuthenticated ? httpContext.User.Identity.Name : "Guest"; //Gets user Name from user Identity  
                LogContext.PushProperty("Username", userName); //Push user in LogContext;  
                await next.Invoke();
            }
           );

            app.MapControllers();

            app.Run();
        }
    }
}
