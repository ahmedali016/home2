namespace SellDeer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        public int id { get; set; }

        [StringLength(100)]
        public string customer_name { get; set; }

        [StringLength(100)]
        public string mail { get; set; }

        [StringLength(200)]
        public string address { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(20)]
        public string mobile { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_of_birth { get; set; }

        public bool? gender { get; set; }

        public bool del_flag { get; set; }

        public bool? suspend { get; set; }

        public int? rank { get; set; }

        [StringLength(50)]
        public string customer_user { get; set; }

        [StringLength(50)]
        public string customer_password { get; set; }

        [Column(TypeName = "date")]
        public DateTime? created_date { get; set; }

        public string note { get; set; }
    }
}
