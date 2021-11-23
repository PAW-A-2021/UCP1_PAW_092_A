using System;
using System.Collections.Generic;

namespace OnlineShop.Models
{
    public partial class Customer
    {
        public int IdCustomer { get; set; }
        public string Nama { get; set; }
        public string Email { get; set; }
        public string Telepon { get; set; }
        public string Alamat { get; set; }
        public string Kota { get; set; }
    }
}
