using System;
using System.Collections.Generic;
using System.Text;

namespace BobileStoreApp
{
    // Class representing a phone
    public class Phone
    {
        public int MobileCode { get; set; }
        public string make { get; set; }
        public int quantity { get; set; }

        public Phone(int mobileCode, string make, int quantity)
        {
            MobileCode = mobileCode;
            this.make = make;
            this.quantity = quantity;
        }

        // Method to get phone details
        public String GetPhoneDetails()
        {
            return $"Mobile Code: {MobileCode}, \nMake: {make}, \nQuantity: {quantity}";
        }

    }
}
