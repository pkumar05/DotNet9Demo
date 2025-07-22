namespace Domain.DTO
{
    public class AddDepartmentRequest
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Descriptions { get; set; }
        public bool Active { get; set; }
    }

    public class UpdateDepartmentRequest : AddDepartmentRequest
    {
        public string Id { get; set; }
        private new bool Active { get; set; }
    }
}
