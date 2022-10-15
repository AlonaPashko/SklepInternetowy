using System.ComponentModel.DataAnnotations;

namespace SklepInternetowy
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Please, enter the name of the category")]
        [StringLength(100)]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Please, enter the description of the category")]
        public string CategoryDescription { get; set; }
        public string IconFileName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}