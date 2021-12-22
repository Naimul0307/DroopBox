
using Microsoft.AspNetCore.Identity;


namespace DoorBoxApp.Models.Common.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        public int UserTypeId { get; set; }
        public UserType UserType { get; set; }
        public string OTPUser { get; set; }

        public byte Status { get; set; }
        public string PaymentMethod { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string AccountNumber { get; set; }
        public string RoutingNumber { get; set; }
        public string MobileBankingNumber { get; set; }
        public string BankCustomerName { get; set; }

    }
}
