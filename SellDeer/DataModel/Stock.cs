namespace SellDeer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stock")]
    public partial class Stock
    {
        public int id { get; set; }

        public int item_id { get; set; }

        public int amount { get; set; }

        public int? order_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime created_date { get; set; }

        public int user_id { get; set; }

        public bool del_flag { get; set; }
    }
}
