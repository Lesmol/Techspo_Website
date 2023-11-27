using System.ComponentModel.DataAnnotations;

namespace Work_Integrated_Learning.Models
{
    public class Reviews
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Reviewer name is required")]
        public string ReviewerName { get; set; }

        [Required(ErrorMessage = "Review message is required")]
        public string ReviewMessage { get; set; }

        [Required(ErrorMessage = "Review date is required")]
        [DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; }
    }
}
