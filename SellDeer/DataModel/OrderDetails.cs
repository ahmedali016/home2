namespace SellDeer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetails
    {
        public int id { get; set; }

        public int? order_id { get; set; }

        public int? product_id { get; set; }

        public DateTime? add_date { get; set; }

        public decimal? product_price { get; set; }

        public decimal? product_discount { get; set; }

        public decimal? product_orignal_price { get; set; }
    }
}
