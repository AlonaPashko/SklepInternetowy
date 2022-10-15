using System.ComponentModel.DataAnnotations;

namespace SklepInternetowy
{
    public class Course
    {
        public int CourseId { get; set; }
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Please, enter the name of the course")]
        [StringLength(100)]
        public string CourseName { get; set; }
        [Required(ErrorMessage = "Please, enter the name of the autor")]
        [StringLength(100)]
        public string AutorOfCourse { get; set; }
        public DateTime AddedDate { get; set; }
        [StringLength(100)]
        public string ImgFileName { get; set; }
        public string CourseDescription { get; set; }
        public decimal CoursePrice { get; set; }
        public bool Bestseller { get; set; }
        public bool Hidden { get; set; }

        public virtual Category Category { get; set; }
    }
}
