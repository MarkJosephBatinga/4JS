using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4JS.Shared
{
    public class Book
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        [Required(ErrorMessage = "Cover Image is required")]
        public string BookImage { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string BookTitle { get; set; }
        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public string Price { get; set; }
        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; }
    }
}
