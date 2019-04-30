namespace SellDeer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Services
    {
        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string service_name { get; set; }

        [Required]
        [StringLength(200)]
        public string service_nameAr { get; set; }

        public string discription { get; set; }

        public string main_img { get; set; }

        public string img { get; set; }

        public decimal? price { get; set; }

        public bool? del_flag { get; set; }

        [Column(TypeName = "date")]
        public DateTime? created_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? updated_date { get; set; }

        public int? modify_user_id { get; set; }

        public int? service_cat_id { get; set; }

        public int? sub_service_id { get; set; }

        public string note { get; set; }
    }
}
