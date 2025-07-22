using PK.BuildingBlocks.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Employees", Schema = "DS")]
    public class Employees : BaseEntity
    {

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string HomeAddress { get; set; }

        public string CurrentTitle { get; set; }

        public string Data { get; set; }
        public bool Active { get; set; }
    }
}
