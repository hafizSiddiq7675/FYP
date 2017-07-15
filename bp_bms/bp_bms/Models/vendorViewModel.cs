using System.ComponentModel.DataAnnotations;
namespace bp_bms.Models
{
    public class vendorViewModel
    {
        //Differnce between Display and Display Name, Why I m Using Display(Name="..")
        //Add Velidations
        [Key]
        public int id { get; set; }
        [Display(Name="Vendor Identification")]
        [Required]
        public string vid { get; set; }
        [Display(Name="Account ID")]
        [Required]
        public string accID { get; set; }
        [Display(Name="First Name")]
        [Required]
        public string fname { get; set; }
        [Display(Name="Last Name")]
        [Required]
        public string lname { get; set; }
        [Display(Name="Postal Address")]
        [Required]
        public string address { get; set; }
        [Display(Name="Contact Number")]
        [Required]
        public string phone { get; set; }
        [Display(Name="Email Address")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Select Bank Account")]
        public string BankName { get; set; }
        [Display(Name="Bank Account Title of Vendor")]
        public string BankAcTitle { get; set; }
        [Display(Name="Bank Account Number")]
        public string BankAcNo { get; set; }
    }
}