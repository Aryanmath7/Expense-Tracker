using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName = "varchar(255)")]
        [MaxLength(255)]
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Column(TypeName = "varchar(255)")]
        [MaxLength(255)]
        public string Icon { get; set; } = "";

        [Column(TypeName = "varchar(10)")]
        [MaxLength(10)]
        public string Type { get; set; } = "Expense";

        [NotMapped]
        public string? TitleWithIcon
        {
            get
            {
                return this.Icon + " " + this.Title;
            }

        }
    }
}
