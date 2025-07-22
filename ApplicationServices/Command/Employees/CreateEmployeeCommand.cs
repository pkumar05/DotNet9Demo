using Domain.DTO;
using Domain.Entities;
using System.Text.Json;

namespace ApplicationServices.Command
{
    public static class CreateEmployeeCommand
    {
        /// <summary>
        /// Create command to add new Profile.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="createdBy"></param>
        /// <returns></returns>
        internal static async Task<Employees> CreateEmployee(AddEmployeeRequest request, string createdBy)
        {
            Employees employee = new Employees()
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = request.FirstName,
                MiddleName = request.MiddleName ?? null,
                LastName = request.LastName,
                Email = request.Email,
                Phone = request.Phone?? null,
                HomeAddress = request.HomeAddress ?? null,
                CurrentTitle = request.CurrentTitle ?? null,
                Data = JsonSerializer.Serialize(request.Data) ?? null,   // to deserialize JsonSerializer.Deserialize<Data>(request.Data);
                Active = true,
                CreatedBy = createdBy,
                CreatedDate = DateTime.Now,

            };

            return await Task.Run(() => employee);

        }


    }
}
