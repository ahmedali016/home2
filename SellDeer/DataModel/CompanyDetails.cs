namespace SellDeer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CompanyDetails
    {
        public int id { get; set; }

        public int? company_id { get; set; }

        [StringLength(100)]
        public string company_branch_name { get; set; }

        [StringLength(100)]
        public string company_branch_nameAr { get; set; }

        [StringLength(300)]
        public string img { get; set; }

        [StringLength(200)]
        public string address { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(20)]
        public string mobile { get; set; }

        public string note { get; set; }

        public bool? del_flag { get; set; }
    }
}
