using Microsoft.EntityFrameworkCore;
using MvcOnlineAutomation.Models.Classes;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Admin> Admins { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Current> Currents { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<InvoiceValue> InvoiceValues { get; set; }
    public DbSet<Personnel> Personnels { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<SalesTransaction> SalesTransactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Decimal tipine hassasiyet ve ölçek ekleyin
        modelBuilder.Entity<Expense>()
            .Property(e => e.ExpenseAmount)
            .HasColumnType("decimal(18, 2)");

        modelBuilder.Entity<InvoiceValue>()
            .Property(iv => iv.InvoiceItemTotal)
            .HasColumnType("decimal(18, 2)");

        modelBuilder.Entity<InvoiceValue>()
            .Property(iv => iv.InvoiceItemUnitPrice)
            .HasColumnType("decimal(18, 2)");

        modelBuilder.Entity<Product>()
            .Property(p => p.ProductPurchasePrice)
            .HasColumnType("decimal(18, 2)");

        modelBuilder.Entity<Product>()
            .Property(p => p.ProductSalesPrice)
            .HasColumnType("decimal(18, 2)");

        modelBuilder.Entity<SalesTransaction>()
            .Property(st => st.TransactionPrice)
            .HasColumnType("decimal(18, 2)");

        modelBuilder.Entity<SalesTransaction>()
            .Property(st => st.TransactionTotalAmount)
            .HasColumnType("decimal(18, 2)");

        base.OnModelCreating(modelBuilder);
    }
}
