using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataTransferProject.MssqlModels
{
    public partial class StockContext : DbContext
    {
        public StockContext()
        {
        }

        public StockContext(DbContextOptions<StockContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CustomerCompany> CustomerCompany { get; set; }
        public virtual DbSet<CustomerGroup> CustomerGroup { get; set; }
        public virtual DbSet<CustomerStation> CustomerStation { get; set; }
        public virtual DbSet<DboCurrency> DboCurrency { get; set; }
        public virtual DbSet<DeviceReader> DeviceReader { get; set; }
        public virtual DbSet<Gsm> Gsm { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Package> Package { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Stock;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryName).HasMaxLength(25);
            });

            modelBuilder.Entity<CustomerCompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.Property(e => e.CompanyId).ValueGeneratedNever();

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.HasOne(d => d.GroupNavigation)
                    .WithMany(p => p.CustomerCompany)
                    .HasForeignKey(d => d.Group)
                    .HasConstraintName("FK_CustomerCompany_CustomerGroup");
            });

            modelBuilder.Entity<CustomerGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.Property(e => e.GroupId).ValueGeneratedNever();

                entity.Property(e => e.GroupName).HasMaxLength(50);
            });

            modelBuilder.Entity<CustomerStation>(entity =>
            {
                entity.HasKey(e => e.StationId);

                entity.Property(e => e.StationId).ValueGeneratedNever();

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.PowerPlant).HasMaxLength(10);

                entity.Property(e => e.StationName).HasMaxLength(200);

                entity.Property(e => e.StationOfficer).HasMaxLength(50);

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.CustomerStation)
                    .HasForeignKey(d => d.Company)
                    .HasConstraintName("FK_CustomerStation_CustomerCompany");
            });

            modelBuilder.Entity<DboCurrency>(entity =>
            {
                entity.HasKey(e => e.CurrencyId);

                entity.ToTable("dbo.Currency");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<DeviceReader>(entity =>
            {
                entity.Property(e => e.DeviceReaderName).HasMaxLength(25);
            });

            modelBuilder.Entity<Gsm>(entity =>
            {
                entity.Property(e => e.GsmCompany).HasMaxLength(20);

                entity.Property(e => e.GsmLocation)
                    .HasColumnName(@"Gsm
Location")
                    .HasMaxLength(30);

                entity.Property(e => e.GsmNumber).HasMaxLength(20);

                entity.Property(e => e.GsmQuota)
                    .HasColumnName(@"Gsm
Quota")
                    .HasMaxLength(10);

                entity.Property(e => e.StationName).HasMaxLength(30);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasKey(e => e.SerialNoId)
                    .HasName("PK_TBLLOG");

                entity.Property(e => e.Address).HasMaxLength(300);

                entity.Property(e => e.SerialNo).HasMaxLength(12);

                entity.Property(e => e.Statement).HasMaxLength(30);

                entity.Property(e => e.StationName).HasMaxLength(20);

                entity.Property(e => e.Status).HasMaxLength(12);

                entity.Property(e => e.TransactionDate).HasColumnType("date");
            });

            modelBuilder.Entity<Logs>(entity =>
            {
                entity.Property(e => e.Explanation).HasMaxLength(500);

                entity.Property(e => e.GeneralId).HasMaxLength(50);

                entity.Property(e => e.NameOfTheProduct).HasMaxLength(50);

                entity.Property(e => e.StationName).HasMaxLength(20);

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.WhichMenu).HasMaxLength(50);

                entity.HasOne(d => d.CustomerNavigation)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.Customer)
                    .HasConstraintName("FK_Logs_CustomerStation");
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.HasIndex(e => e.PackageNo)
                    .HasName("IX_Package_PackageNo_Unique")
                    .IsUnique();

                entity.Property(e => e.CargoNumber).HasMaxLength(40);

                entity.Property(e => e.PackageNo)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SellingDate).HasColumnType("date");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Package_CustomerStation");

                entity.HasOne(d => d.DeviceReader)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.DeviceReaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Package_DeviceReader");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK_TBLSTOCK");

                entity.Property(e => e.Brand).HasMaxLength(255);

                entity.Property(e => e.DateOfPurchase).HasColumnType("date");

                entity.Property(e => e.Explanation).HasMaxLength(255);

                entity.Property(e => e.PackageNo).HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductName).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.StockSerialNo)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.Stock)
                    .HasForeignKey(d => d.Category)
                    .HasConstraintName("FK_Stock_Category");

                entity.HasOne(d => d.CurrencyTypeNavigation)
                    .WithMany(p => p.Stock)
                    .HasForeignKey(d => d.CurrencyType)
                    .HasConstraintName("FK_Stock_dbo.Currency");

                entity.HasOne(d => d.PackageNoNavigation)
                    .WithMany(p => p.Stock)
                    .HasPrincipalKey(p => p.PackageNo)
                    .HasForeignKey(d => d.PackageNo)
                    .HasConstraintName("FK_Stock_Package1");
            });

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.TaskDescription).HasMaxLength(200);

                entity.Property(e => e.TaskId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Role).HasMaxLength(30);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
