using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnionArchitecture.ServicesLayer.ViewModels
{
    public class CustomerViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        [MaxLength(200)]
        [DisplayName("CustomerName")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "O campo de compras é obrigatório!")]
        [MaxLength(100, ErrorMessage = "O campo PurchasesProduct deve ter comprimento máximo de '100' caracteres!")]
        [DisplayName("PurchasesProduct")]
        public string PurchasesProduct { get; set; }

        [Required(ErrorMessage = "O campo tipo de compra é obrigatório!")]
        [MaxLength(50)]
        [DisplayName("PurchasesProduct")]
        public string PaymentType { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }
        
        public bool IsActive { get; set; }

    }
}
