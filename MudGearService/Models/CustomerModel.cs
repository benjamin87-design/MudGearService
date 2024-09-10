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

		[Column("StreetName")]
		public string StreetName { get; set; }

		[Column("StreetNumber")]
		public string StreetNumber { get; set; }

		[Column("ZIPCode")]
		public string ZIPCode { get; set; }

		[Column("City")]
		public string City { get; set; }

		[Column("Country")]
		public string Country { get; set; }
	}

}
