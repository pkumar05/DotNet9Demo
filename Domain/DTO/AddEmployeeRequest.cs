namespace Domain.DTO
{
    public class AddEmployeeRequest
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string HomeAddress { get; set; }
        public string CurrentTitle { get; set; }
        public Data Data { get; set; }
        
        public bool Active { get; set; }
    }

    public class Data { }

    public class UpdateEmpoyeeRequest : AddEmployeeRequest
    {
        public string Id { get; set; }
        private new bool Active { get; set; }
        private new string CurrentTitle { get; set; }
    }
}
