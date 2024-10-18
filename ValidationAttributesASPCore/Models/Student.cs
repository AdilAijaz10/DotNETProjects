using System.ComponentModel.DataAnnotations;

namespace ValidationAttributesASPCore.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Please write your Name")]
        [StringLength(15,MinimumLength = 3,ErrorMessage ="write between 3 to 15 characters")]
        //[MinLength(3)]
        //[MaxLength(15)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please write your Email")]
        //[EmailAddress]
        [RegularExpression("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$",ErrorMessage ="Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter your Age")]
        [Range(10,50,ErrorMessage ="Age Between 10 to 50")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Please Enter your password")]
        [RegularExpression("^(?=.*[A-Za-z])(?=.*\\d)(?=.*[@$!%*#?&])[A-Za-z\\d@$!%*#?&]{8,}$", 
            ErrorMessage ="uppercase,lowercase,8 characters,1 special character")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Confirm password")]
        [Compare("Password",ErrorMessage = "uppercase,lowercase,8 characters,1 special character")]
        [Display(Name = "Confirm Password")]
        public string ComparePassword { get; set; }

        [Required(ErrorMessage = "Please Enter your Phone Number")]
        [RegularExpression("^((\\+92)|(0092))-{0,1}\\d{3}-{0,1}\\d{7}$|^\\d{11}$|^\\d{4}-\\d{7}$", 
            ErrorMessage = "Invalid Phone number")]
        public string PNumber { get; set; }

        [Required(ErrorMessage = "Please Enter Wesite URL")]
        [Url(ErrorMessage= "Invalid URL")]
        public string WebsiteURL { get; set; }
    }
}
