using PK.BuildingBlocks.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Profile", Schema = "DS")]
    public class Profile : BaseEntity
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public string Descriptions { get; set; }

        public bool Active { get; set; }
    }
}
