using System.ComponentModel.DataAnnotations;

namespace FeedbackManagementMVC.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [Display(Name = "Name")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Display(Name = "Email")]
        public string Email { get; set; } = "";

        [Display(Name = "Category")]
        public string Category { get; set; } = "";

        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        [Display(Name = "Rating")]
        public int? Rating { get; set; }

        [Required(ErrorMessage = "Please enter your feedback.")]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "Feedback must be between 5 and 250 characters.")]
        [Display(Name = "Feedback")]
        public string Message { get; set; } = "";

        [StringLength(250, ErrorMessage = "Suggestions cannot exceed 250 characters.")]
        [Display(Name = "Suggestions")]
        public string Suggestions { get; set; } = "";

        [Display(Name = "Would you recommend this course?")]
        public string Recommend { get; set; } = "";

        [Display(Name = "Date")]
        public DateTime SubmittedOn { get; set; } = DateTime.Now;
    }
}
