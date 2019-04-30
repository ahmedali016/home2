namespace SellDeer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public int id { get; set; }

        [StringLength(50)]
        public string user_name { get; set; }

        [StringLength(50)]
        public string user_password { get; set; }

        [StringLength(100)]
        public string emp_name { get; set; }

        [StringLength(20)]
        public string emp_phone { get; set; }

        [StringLength(900)]
        public string note { get; set; }

        public bool? del_flag { get; set; }

        public int? authorization_level { get; set; }
    }
}
