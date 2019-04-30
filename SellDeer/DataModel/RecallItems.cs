namespace SellDeer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RecallItems
    {
        public int id { get; set; }

        public int? product_id { get; set; }

        public int? quantity { get; set; }

        public DateTime? recall_date { get; set; }

        public int? modify_user_id { get; set; }

        public bool? del_flag { get; set; }
    }
}
