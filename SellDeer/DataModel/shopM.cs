namespace SellDeer.DataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class shopM : DbContext
    {
        public shopM()
            : base("name=shopM")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompanyDetails> CompanyDetails { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerDetails> CustomerDetails { get; set; }
        public virtual DbSet<CustomerReviews> CustomerReviews { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<OfferDetails> OfferDetails { get; set; }
        public virtual DbSet<Offers> Offers { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<RecallItems> RecallItems { get; set; }
        public virtual DbSet<SecondSub> SecondSub { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<ServicesCategory> ServicesCategory { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<SubCategory> SubCategory { get; set; }
        public virtual DbSet<SubService> SubService { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<CustomerDetails>()
                .Property(e => e.money_paied)
                .HasPrecision(7, 2);

            modelBuilder.Entity<CustomerDetails>()
                .Property(e => e.money_back)
                .HasPrecision(7, 2);

            modelBuilder.Entity<OfferDetails>()
                .Property(e => e.price_in_offer)
                .HasPrecision(7, 2);

            modelBuilder.Entity<OfferDetails>()
                .Property(e => e.price_out_offer)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Offers>()
                .Property(e => e.offer_percentage)
                .HasPrecision(4, 2);

            modelBuilder.Entity<OrderDetails>()
                .Property(e => e.product_price)
                .HasPrecision(7, 2);

            modelBuilder.Entity<OrderDetails>()
                .Property(e => e.product_discount)
                .HasPrecision(7, 2);

            modelBuilder.Entity<OrderDetails>()
                .Property(e => e.product_orignal_price)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Orders>()
                .Property(e => e.order_price)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Orders>()
                .Property(e => e.total_price)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Orders>()
                .Property(e => e.total_discount)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Products>()
                .Property(e => e.product_price)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Services>()
                .Property(e => e.price)
                .HasPrecision(7, 2);

            modelBuilder.Entity<ServicesCategory>()
                .Property(e => e.modify_user_id)
                .IsFixedLength();
        }
    }
}
