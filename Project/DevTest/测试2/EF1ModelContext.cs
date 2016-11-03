namespace DevTest.测试2
{
    using System.Data.Entity;

    public partial class EF1ModelContext : DbContext
    {
        public EF1ModelContext()
            : base("name=EF1ModelConStr")
        { }

        public virtual DbSet<t费用收入> t费用收入 { get; set; }
        public virtual DbSet<t合约业务> t合约业务 { get; set; }
        public virtual DbSet<v费用收入> v费用收入 { get; set; }
        public virtual DbSet<v合约业务> v合约业务 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<t合约业务>()
                .Property(e => e.stamp)
                .IsFixedLength();

            modelBuilder.Entity<t合约业务>()
                .HasMany(e => e.t费用收入)
                .WithRequired(e => e.t合约业务)
                .HasForeignKey(e => e.fPID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<v费用收入>()
                .Property(e => e.类别)
                .IsUnicode(false);

            modelBuilder.Entity<v费用收入>()
                .Property(e => e.状态)
                .IsUnicode(false);

            modelBuilder.Entity<v合约业务>()
                .Property(e => e.运营商ID)
                .IsUnicode(false);

            modelBuilder.Entity<v合约业务>()
                .Property(e => e.捆绑终端)
                .IsUnicode(false);

            modelBuilder.Entity<v合约业务>()
                .Property(e => e.允许老号)
                .IsUnicode(false);

            modelBuilder.Entity<v合约业务>()
                .Property(e => e.开始时间)
                .IsUnicode(false);

            modelBuilder.Entity<v合约业务>()
                .Property(e => e.结束时间)
                .IsUnicode(false);

            modelBuilder.Entity<v合约业务>()
                .Property(e => e.状态)
                .IsUnicode(false);

            modelBuilder.Entity<v合约业务>()
                .Property(e => e.时间戳)
                .IsFixedLength();
        }
    }
}
