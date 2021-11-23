using System;
using System.Collections.Generic;

namespace OnlineShop.Models
{
    public partial class Order
    {
        public int IdOrder { get; set; }
        public decimal? Jumlah { get; set; }
        public TimeSpan? TanggalPembelian { get; set; }
    }
}
