using System;
using System.Collections.Generic;

namespace OnlineShop.Models
{
    public partial class Produk
    {
        public int IdProduk { get; set; }
        public string Nama { get; set; }
        public decimal? Harga { get; set; }
        public string Deskripsi { get; set; }
    }
}
