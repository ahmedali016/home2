namespace SellDeer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomerDetails
    {
        public int id { get; set; }

        public int? cust_id { get; set; }

        public int? order_id { get; set; }

        public decimal? money_paied { get; set; }

        public decimal? money_back { get; set; }

        public bool? del_flag { get; set; }

        public string note { get; set; }
    }
}
