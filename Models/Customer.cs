using System.ComponentModel.DataAnnotations;

namespace customers_inventory.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }
        public string? Gender { get; set; }
        public decimal Age { get; set; }
    }
}
