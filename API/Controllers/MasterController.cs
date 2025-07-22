using Domain.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceInterface;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : DemoSolutionNET9ControllerBase
    {
        #region Commented Codes
        //// GET: api/<MasterController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<MasterController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<MasterController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<MasterController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<MasterController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
        #endregion
        private readonly IMasterService _masterService;
        public MasterController(IMasterService masterService,
             ILogger<MasterController> logger
            ) :base(logger)
        {
            _masterService = masterService;
        }

        [Authorize]
        [HttpPost]
        [Route("AddDepartment")]
        //[HasPermission(ProcessName = "MASTER", SubProcessName = "CREATE")]
        public async Task<IActionResult> AddDepartment(AddDepartmentRequest request)
        {
            string user = User.Identity.Name;
            Serilog.Log.Information("Started --Log Of Master--> AddDepartment method ");
            try
            {
                var result = await _masterService.AddDepartment(request, user);
                return Ok(result);
            }

            catch (Exception ex)
            {
                Serilog.Log.Error("Error: Log Of Master-->AddDepartment method Error:", ex.Data);
                return HandleUserException(ex);
            }
        }

        [Authorize]
        [HttpGet]
        // [Route("GetDepartmentList/{searchfield}")]
        [Route("GetDepartmentList")]
        //[HasPermission(ProcessName = "MASTER", SubProcessName = "READ")]
        public async Task<IActionResult> GetDepartmentList(string searchField)
        {
            string user = User.Identity.Name;
            Serilog.Log.Information("Started --Log Of Master--> GetDepartmentList method ");
            try
            {
                var result = await _masterService.GetDepartmentList(searchField, user);
                return Ok(result);
            }

            catch (Exception ex)
            {
                Serilog.Log.Error("Error: Log Of Master-->GetDepartmentList method Error:", ex.Data);
                return HandleUserException(ex);
            }
        }

       
        [HttpPut]
        // [Route("GetDepartmentList/{searchfield}")]
        [Route("UpdateDepartment")]
        //[HasPermission(ProcessName = "MASTER", SubProcessName = "READ")]
        public async Task<IActionResult> UpdateDepartment(UpdateDepartmentRequest request)
        {
            string user = User.Identity.Name;
            Serilog.Log.Information("Started --Log Of Master--> UpdateDepartment method ");
            try
            {
                var result = await _masterService.UpdateDepartment(request, user);
                return Ok(result);
            }

            catch (Exception ex)
            {
                Serilog.Log.Error("Error: Log Of Master-->UpdateDepartment method Error:", ex.Data);
                return HandleUserException(ex);
            }
        }

        
        [HttpPost]
        [Route("AddProfile")]
        //[HasPermission(ProcessName = "MASTER", SubProcessName = "CREATE")]
        public async Task<IActionResult> AddProfile(AddProfileRequest request)
        {
            string user = User.Identity.Name;
            Serilog.Log.Information("Started --Log Of Master--> AddProfile method ");
            try
            {
                var result = await _masterService.AddProfile(request, user);
                return Ok(result);
            }

            catch (Exception ex)
            {
                Serilog.Log.Error("Error: Log Of Master-->AddProfile method Error:", ex.Data);
                return HandleUserException(ex);
            }
        }

        
        [HttpGet]
        // [Route("GetDepartmentList/{searchfield}")]
        [Route("GetProfileList")]
        //[HasPermission(ProcessName = "MASTER", SubProcessName = "READ")]
        public async Task<IActionResult> GetProfileList(string searchField)
        {
            string user = User.Identity.Name;
            Serilog.Log.Information("Started --Log Of Master--> GetProfileList method ");
            try
            {
                var result = await _masterService.GetProfileList(searchField, user);
                return Ok(result);
            }

            catch (Exception ex)
            {
                Serilog.Log.Error("Error: Log Of Master-->GetProfileList method Error:", ex.Data);
                return HandleUserException(ex);
            }
        }

       
        [HttpPut]
        // [Route("GetDepartmentList/{searchfield}")]
        [Route("UpdateProfile")]
        //[HasPermission(ProcessName = "MASTER", SubProcessName = "UPDATE")]
        public async Task<IActionResult> UpdateProfile(UpdateProfileRequest request)
        {
            string user = User.Identity.Name;
            Serilog.Log.Information("Started --Log Of Master--> UpdateProfile method ");
            try
            {
                var result = await _masterService.UpdateProfile(request, user);
                return Ok(result);
            }

            catch (Exception ex)
            {
                Serilog.Log.Error("Error: Log Of Master-->UpdateProfile method Error:", ex.Data);
                return HandleUserException(ex);
            }
        }

        
        [HttpPost]
        [Route("AddEmployee")]
        //[HasPermission(ProcessName = "MASTER", SubProcessName = "CREATE")]
        public async Task<IActionResult> AddEmployee(AddEmployeeRequest request)
        {
            string user = User.Identity.Name;
            Serilog.Log.Information("Started --Log Of Master--> AddEmployee method ");
            try
            {
                var result = await _masterService.AddEmployee(request, user);
                return Ok(result);
            }

            catch (Exception ex)
            {
                Serilog.Log.Error("Error: Log Of Master-->AddEmployee method Error:", ex.Data);
                return HandleUserException(ex);
            }
        }

        
        [HttpGet]
        // [Route("GetDepartmentList/{searchfield}")]
        [Route("GetEmployeeList")]
        //[HasPermission(ProcessName = "MASTER", SubProcessName = "READ")]
        public async Task<IActionResult> GetEmployeeList(string searchField)
        {
            string user = User.Identity.Name;
            Serilog.Log.Information("Started --Log Of Master--> GetEmployeeList method ");
            try
            {
                var result = await _masterService.GetEmployeeList(searchField, user);
                return Ok(result);
            }

            catch (Exception ex)
            {
                Serilog.Log.Error("Error: Log Of Master-->GetEmployeeList method Error:", ex.Data);
                return HandleUserException(ex);
            }
        }

        
        [HttpPut]
        [Route("UpdateEmployee")]
        //[HasPermission(ProcessName = "MASTER", SubProcessName = "UPDATE")]
        public async Task<IActionResult> UpdateEmployee(UpdateEmpoyeeRequest request)
        {
            string user = User.Identity.Name;
            Serilog.Log.Information("Started --Log Of Master--> UpdateEmployee method ");
            try
            {
                var result = await _masterService.UpdateEmployee(request, user);
                return Ok(result);
            }

            catch (Exception ex)
            {
                Serilog.Log.Error("Error: Log Of Master-->UpdateEmployee method Error:", ex.Data);
                return HandleUserException(ex);
            }
        }



    }
}
