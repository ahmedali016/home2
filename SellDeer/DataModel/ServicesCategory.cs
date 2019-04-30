namespace SellDeer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServicesCategory")]
    public partial class ServicesCategory
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string service_name { get; set; }

        [Required]
        [StringLength(100)]
        public string service_nameAr { get; set; }

        public string description { get; set; }

        public string img { get; set; }

        public bool? del_flag { get; set; }

        [Column(TypeName = "date")]
        public DateTime? created_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? updated_date { get; set; }

        [StringLength(10)]
        public string modify_user_id { get; set; }

        public string note { get; set; }
    }
}
