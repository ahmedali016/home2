namespace SellDeer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string cat_name { get; set; }

        [Required]
        [StringLength(50)]
        public string cat_nameAr { get; set; }

        public string discription { get; set; }

        public string img { get; set; }

        public bool? del_flag { get; set; }

        [Column(TypeName = "date")]
        public DateTime? created_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? updated_date { get; set; }

        public int modify_user_id { get; set; }
    }
}
