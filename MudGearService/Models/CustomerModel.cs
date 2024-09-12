using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace MudGearService.Models
{
	[Table("Customer")]
	public class CustomerModel : BaseModel
    {
		[PrimaryKey("id")]
		public int ID { get; set; }

		[Column("CustomerName")]
		public string CustomerName { get; set; }

		[Column("UserStreetName")]
		public string StreetName { get; set; }

		[Column("UserStreetNumber")]
		public string StreetNumber { get; set; }

		[Column("UserZIPCode")]
		public string ZIPCode { get; set; }

		[Column("UserCity")]
		public string City { get; set; }

		[Column("UserCountry")]
		public string Country { get; set; }
	}

}
