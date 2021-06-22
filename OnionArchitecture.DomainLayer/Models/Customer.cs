using System.ComponentModel.DataAnnotations;

namespace OnionArchitecture.DomainLayer.Models
{
    public class Customer: BaseEntity
    {
        //[Required]
        public string CustomerName { get; set; }

        //[Required]
        public string PurchasesProduct { get; set; }

        //[Required]
        public string PaymentType { get; set; }
    }
}
