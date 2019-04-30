namespace SellDeer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {
        public int id { get; set; }

        public DateTime? order_date { get; set; }

        public int? customer_id { get; set; }

        public decimal? order_price { get; set; }

        public DateTime? updated_date { get; set; }

        public int? item_quntity { get; set; }

        public decimal? total_price { get; set; }

        public decimal? total_discount { get; set; }

        public int? modify_user_id { get; set; }

        public bool? del_flag { get; set; }

        public string note { get; set; }
    }
}
