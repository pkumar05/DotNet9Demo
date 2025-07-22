using Domain.DTO;
using Domain.Interfaces;
using DS.ApplicationServices;
using DS.Domain.Validator;
using DS.Infrastructure.SQL.Repositories;
using FluentValidation;
using Infrastructure.SQL.Data;
using Infrastructure.SQL.Repositories;
using PK.BuildingBlocks.Infrastructure;
using PK.BuildingBlocks.Repository;
using ServiceInterface;

namespace API.DependancyConfig
{
    public class DependancyConfig
    {
        private IServiceCollection _services;
        private IConfiguration _configuration;
        public DependancyConfig(IServiceCollection services, IConfiguration configuration)
        {
            _services = services;
            _configuration = configuration;
        }

        public void ConfigureServices()
        {
            AddDependencyValidator();
            AddDependencyRepository();
            AddDependencyService();
        }

        private void AddDependencyValidator()
        {
            _services.AddScoped<IValidator<AddDepartmentRequest>, AddDepartmentValidatorRequest>();
            _services.AddScoped<IValidator<AddProfileRequest>, AddProfileValidatorRequest>();
            _services.AddScoped<IValidator<AddEmployeeRequest>, AddEmployeeValidatorRequest>();


        }
        private void AddDependencyRepository()
        {
            _services.AddScoped(typeof(IRepository<>), typeof(RepositoryEF<>));

            _services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));

            _services.AddScoped<IDepartmentsRequestRepos, DepartmentsRequestRepository>();
            _services.AddScoped<IProfileRequestRepos, ProfileRequestRepository>();
            _services.AddScoped<IEmployeeRequestRepos, EmployeeRequestRepository>();
            _services.AddScoped<IEmployeeProfileRequestRepos, EmployeeProfileRequestRepository>();


        }
        private void AddDependencyService()
        {
            _services.AddScoped<IMasterService, MasterService>();

        }
    }
}
