using System.ComponentModel.DataAnnotations;

namespace SklepInternetowy
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required(ErrorMessage = "Please, enter the name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please, enter the surname")]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Please, enter the street name")]
        [StringLength(100)]
        public string Street { get; set; }
        [Required(ErrorMessage = "Please, enter the city name")]
        [StringLength(100)]
        public string City { get; set; }
        [Required(ErrorMessage = "Please, enter the ZIP Code")]
        [StringLength(6)]
        public string ZipCode { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime AddedDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal OrderPrice { get; set; }

        List<OrderItem> OrderItems { get; set; }
    }

    public enum OrderStatus
    {
        New,
        Realized
    }
}
