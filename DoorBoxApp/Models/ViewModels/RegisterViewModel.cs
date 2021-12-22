﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoorBoxApp.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please Enter a User Name")]
        [Display(Name = "User Name")]
        public string UserName { set; get; }

        [Required(ErrorMessage = "Please Enter Full Name")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter a Password")]
        [DataType(DataType.Password)]
        public string Password { set; get; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password Do Not Match")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Phone Number")]
        //[Required(ErrorMessage = "Please Enter the Phone Number of C&F Agent")]
        public string PhoneNumber { get; set; }
        
        [Display(Name = "Payment Method")]
        //[Required(ErrorMessage = "Please Enter the Phone Number of C&F Agent")]
        public string PaymentMethod { get; set; }
        public string MobileBankingNumber { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string AccountNumber { get; set; }
        public string RoutingNumber { get; set; }
        public string BankCustomerName { get; set; }

        //[Required(ErrorMessage = "Please Enter the Address of C&F Agent")]
        public string Address { get; set; }

      
    }
}
