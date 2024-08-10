using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        //public int Id { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(3,ErrorMessage = "طول نام باید بیشتر از 3 کاراکتر باشد")]
        [MaxLength(100,ErrorMessage = "طول نام باید کمتر از 100 کاراکتر باشد")]
        public string Name { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده صحیح نیست")]
        public string Email { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]
        public string Message { get; set; }
        //[Required(ErrorMessage = "این فیلد اجباری است")]
        public SelectList Services { get; set; }
    }
}
