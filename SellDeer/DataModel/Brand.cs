namespace SellDeer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Brand")]
    public partial class Brand
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string brand_name { get; set; }

        public bool del_flag { get; set; }
    }
}
