using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using loginpage1.Models.Extended;

namespace loginpage1.Models
{
    [MetadataType(typeof(usermetadata))]
    public partial class user
    {
        public string ConfirmPassword { get; set; }
    }
    public class usermetadata
    {
        [ Display(Name= "first Name")]
        [ Required(AllowEmptyStrings= false,ErrorMessage="First name required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name required")]
        public string LastName { get; set; }

        [Display(Name = "Email ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email ID required")]
        [DataType(DataType.EmailAddress)]
        public string FirstName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.DateTime)]
       // [DisplyFormat(ApplyFormatInEditMode = true,DataFormatString = "(0:MM/dd/yyyy)")]
        public DateTime DateOfBirth { get; set; }

        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage="Minimum 6 Characters Required")]
        public string FirstName { get; set; }

        [Display(Name= "Confire Password")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage="Confirm Password and password Do not match")]
        public string ConfirmPassword { get; set; }



    }
}