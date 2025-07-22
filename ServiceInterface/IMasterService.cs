using Domain.DTO;

namespace ServiceInterface
{
    public interface IMasterService
    {
        Task<ServiceResponse> AddDepartment(AddDepartmentRequest request, string createdBy);
        
        Task<ServiceResponse> GetDepartmentList(string searchField, string userName);
        
        Task<ServiceResponse> UpdateDepartment(UpdateDepartmentRequest request,string userName);
        
        Task<ServiceResponse> AddProfile(AddProfileRequest request, string createdBy);
        
        Task<ServiceResponse> GetProfileList(string searchField, string userName);
        
        Task<ServiceResponse> UpdateProfile(UpdateProfileRequest request, string userName);
        
        Task<ServiceResponse> AddEmployee(AddEmployeeRequest request, string cretedBy);
        
        Task<ServiceResponse> GetEmployeeList(string searchField, string userName);
      
        Task<ServiceResponse> UpdateEmployee(UpdateEmpoyeeRequest request, string userName);
    }
}
