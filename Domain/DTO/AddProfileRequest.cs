namespace Domain.DTO
{
    public class AddProfileRequest
    {
        public string Name { get; set; }
        
        public string Code { get; set; }
       
        public string Descriptions { get; set; }
        
        public bool Active { get; set; }
    }

    public class UpdateProfileRequest : AddProfileRequest
    {
        public string Id { get; set; }
        private new bool Active { get; set; }
    }
}
