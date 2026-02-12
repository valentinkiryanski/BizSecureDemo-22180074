using System.ComponentModel.DataAnnotations;

namespace BizSecureDemo22180074.ViewModels
{
    public class CreateOrderVm
    {
        [Required, MaxLength(80)]
        //[Required, MaxLength(300)]
        public string Title { get; set; } = "";
        [Required]
        public decimal Amount { get; set; }

    }
}
