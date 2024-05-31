using System.ComponentModel.DataAnnotations;

namespace HarmonyHaven.Models
{
    public class Checkout
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string CardHoldersName { get; set; }

        [MaxLength(16)]
        public int CardNumber { get; set; }
        [MaxLength(5)]
        public string CardExpiryDate { get; set; }
        [MaxLength(3)]
        public int CVC { get; set; }
    }
}