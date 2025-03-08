using System.ComponentModel.DataAnnotations;
using OrdersWebApp.Validation;

namespace OrdersWebApp.Models;

public class Order
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Sender city must be provided")]
    [MinLength(2, ErrorMessage = "Too short")]
    [MaxLength(25, ErrorMessage = "Too long")]
    [RegularExpression(@"^[A-Za-zА-Яа-я\s-]+$", ErrorMessage = "Only letters")]
    public string SenderCity { get; set; }

    [Required(ErrorMessage = "Sender address must be provided")]
    [MinLength(2, ErrorMessage = "Too short")]
    [MaxLength(60, ErrorMessage = "Too long")]
    public string SenderAddress { get; set; }

    [Required(ErrorMessage = "Recipient city must be provided")]
    [MinLength(2, ErrorMessage = "Too short")]
    [MaxLength(25, ErrorMessage = "Too long")]
    [RegularExpression(@"^[A-Za-zА-Яа-я\s-]+$", ErrorMessage = "Only letters")]
    public string RecipientCity { get; set; }

    [Required(ErrorMessage = "Recipient address must be provided")]
    [MinLength(2, ErrorMessage = "Too short")]
    [MaxLength(60, ErrorMessage = "Too long")]
    public string RecipientAddress { get; set; }

    [Required(ErrorMessage = "Cargo weight must be provided")]
    [Range(0, 1000)]
    public float CargoWeight { get; set; }

    [Required(ErrorMessage = "Cargo pickup date must be provided")]
    [DateOnlyFuture]
    public DateOnly CargoPickupDate { get; set; }

    //public Order()
    //{
    //    Id = Guid.NewGuid();
    //    SenderCity = "No data";
    //    SenderAddress = "No data";
    //    RecipientCity = "No data";
    //    RecipientAddress = "No data";
    //    CargoWeight = 0f;
    //    CargoPickupDate = new DateOnly();
    //}

    //public Order(string senderCity, string senderAddress, string recipientCity, string recipientAddress, float cargoWeight, DateOnly cargoPickupDate)
    //{
    //    SenderCity = senderCity;

    //    SenderAddress = senderAddress;

    //    RecipientCity = recipientCity;

    //    RecipientAddress = recipientAddress;

    //    CargoWeight = cargoWeight;

    //    CargoPickupDate = cargoPickupDate;
    //}
}
