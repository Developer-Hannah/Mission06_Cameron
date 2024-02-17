using System.ComponentModel.DataAnnotations;

namespace Mission06_Cameron.Models
{
    public class Form
    {
        [Key]
        [Required]
        public int FormID { get; set;  }
        // public int GetFormID { get;} // read only varriable
        [Required(ErrorMessage = "Category is requiered!")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Title is requiered!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Year is requiered!")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Director is requiered!")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Rating is requiered!")]
        public string Rating { get; set; }
        public string Edited { get; set; }
        public string LentTo  { get; set; }
        [StringLength(25, ErrorMessage = "Notes cannot be more than 25 charachters")]
        public string Notes { get; set; }
}
}
