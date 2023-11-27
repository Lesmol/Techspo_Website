using System.ComponentModel.DataAnnotations;

namespace Work_Integrated_Learning.Models
{
    public class Presenters
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Presenter name is required")]
        public string? PresenterName { get; set; }

        [Required(ErrorMessage = "Presenter image url is required")]
        public string? PresenterImageURL { get; set; }

        [Required(ErrorMessage = "Presenter title is required")]
        public string? PresenterTitle { get; set; }

        [Required(ErrorMessage = "Presenter description is required")]
        public string? PresenterDescription { get; set; }

        [Required(ErrorMessage = "Presentation time is required")]
        [DataType(DataType.Time)]
        public TimeSpan PresentationTime { get; set; }

        [Required(ErrorMessage = "Presentation date is required")]
        [DataType(DataType.Date)]
        public DateTime PresentationDate { get; set; }

        [Required(ErrorMessage = "Presentation stage is required")]
        public string? PresentationStage { get; set; }
    }
}
