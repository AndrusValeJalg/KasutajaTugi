using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace CustomerSupport.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Please enter a description")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a due date")]
        public DateTime? DueDate { get; set; }
        public DateTime DateTime { get; set; }
        public string StatusId { get; set; } = string.Empty;
        [ValidateNever]
        public Status Status { get; set; } = null!;
        public bool Overdue => StatusId == "open" && DueDate < DateTime.Today;
    }
}
