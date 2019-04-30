namespace SellDeer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomerReviews
    {
        public int id { get; set; }

        public int? customer_id { get; set; }

        [StringLength(300)]
        public string title { get; set; }

        public string review { get; set; }

        public DateTime? created_date { get; set; }

        public int? rank { get; set; }
    }
}
