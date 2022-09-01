using System.ComponentModel.DataAnnotations;

namespace BlazorSyncfusion.Models.Orders.Validation
{
    public class CreateOrUpdateOrderValidationModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Your order must have a title")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Status of this order is required")]
        public bool Completed { get; set; }

        [Required(ErrorMessage = "User ID associated with this order is required")]
        [Range(1, 100)]
        public int UserId { get; set; }
    }
}
