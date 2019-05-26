namespace SellDeer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Company")]
    public partial class Company
    {
        public int id { get; set; }

        [StringLength(200)]
        public string company_name { get; set; }
               
        public string brief_discription { get; set; }

        public string description { get; set; }

        public string img { get; set; }

        public string sec_img { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(20)]
        public string sec_phone { get; set; }

        [StringLength(20)]
        public string mobile { get; set; }

        [StringLength(200)]
        public string address { get; set; }

        [StringLength(60)]
        public string mail { get; set; }

        [StringLength(60)]
        public string sec_mail { get; set; }

        [StringLength(20)]
        public string lang { set; get; }

        public int? modify_user_id { get; set; }

        public bool? del_flag { get; set; }
    }
}
