namespace SellDeer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Offers
    {
        public int id { get; set; }

        [StringLength(50)]
        public string offer_name { get; set; }

        [StringLength(50)]
        public string offer_nameAr { get; set; }

        [StringLength(200)]
        public string discription { get; set; }

        public string img { get; set; }

        public decimal? offer_percentage { get; set; }

        [Column(TypeName = "date")]
        public DateTime? start_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? end_date { get; set; }

        public bool? del_flag { get; set; }

        [Column(TypeName = "date")]
        public DateTime? created_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? updated_date { get; set; }

        public int modify_user_id { get; set; }

        public string note { get; set; }
    }
}
