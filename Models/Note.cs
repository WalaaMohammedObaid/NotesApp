using System;
using System.ComponentModel.DataAnnotations;

namespace NotesApp.Models
{
    public class Note
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "العنوان مطلوب")]
        [StringLength(100, ErrorMessage = "العنوان يجب أن لا يتجاوز 100 حرف")]
        [Display(Name = "العنوان")]
        public string Title { get; set; }

        [Required(ErrorMessage = "المحتوى مطلوب")]
        [Display(Name = "المحتوى")]
        public string Content { get; set; }

        [Display(Name = "تاريخ الإنشاء")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}