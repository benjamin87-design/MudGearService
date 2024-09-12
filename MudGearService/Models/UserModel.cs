using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudGearService.Models
{
    [Table("User")]
    public class UserModel : BaseModel
    {
        [PrimaryKey("id")]
        public int ID { get; set; }

        [Column("UserFamilyName")]
        public string UserFamilyName { get; set; }

        [Column("UserGivenName")]
        public string UserGivenName { get; set; }

        [Column("UserPhone")]
        public string UserPhone { get; set; }

        [Column("UserEmail")]
        public string UserEmail { get; set; }

        [Column("UserStreetName")]
        public string UserStreetName { get; set; }

        [Column("UserStreetNumber")]
        public string UserStreetNumber { get; set; }

        [Column("UserZIPCode")]
        public string UserZIPCode { get; set; }

        [Column("UserCity")]
        public string UserCity { get; set; }

        [Column("UserCountry")]
        public string UserCountry { get; set; }
    }
}
