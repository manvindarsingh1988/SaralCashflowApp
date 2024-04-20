using Microsoft.EntityFrameworkCore;

namespace SaralCashFlowAPI.Models
{
    public partial class SaralCashFlowDBContext : DbContext
    {
        public SaralCashFlowDBContext(DbContextOptions
        <SaralCashFlowDBContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<AmountType> AmountTypes { get; set; }
        public virtual DbSet<StatusType> StatusTypes { get; set; }
        public virtual DbSet<CashDetail> CashDetails { get; set; }
        public virtual DbSet<SubCashDetails> SubCashDetails { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(entity => {
                entity.HasKey(k => k.Id);
            });

            modelBuilder.Entity<User>(entity => {
                entity.HasKey(k => k.Id);
            });

            modelBuilder.Entity<Customer>(entity => {
                entity.HasKey(k => k.Id);
            });

            modelBuilder.Entity<AmountType>(entity => {
                entity.HasKey(k => k.Id);
            });

            modelBuilder.Entity<StatusType>(entity => {
                entity.HasKey(k => k.Id);
            });

            modelBuilder.Entity<CashDetail>(entity => {
                entity.HasKey(k => k.Id);
            });

            modelBuilder.Entity<SubCashDetails>(entity => {
                entity.HasKey(k => k.Id);
            });

            modelBuilder.Entity<Message>(entity => {
                entity.HasKey(k => k.Id);
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
