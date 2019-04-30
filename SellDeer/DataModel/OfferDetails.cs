namespace SellDeer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OfferDetails
    {
        public int id { get; set; }

        public int? offer_id { get; set; }

        public int? product_id { get; set; }

        public decimal? price_in_offer { get; set; }

        public decimal? price_out_offer { get; set; }

        public bool? del_flag { get; set; }

        public int? modify_user_id { get; set; }
    }
}
