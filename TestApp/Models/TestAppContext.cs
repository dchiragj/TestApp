using Microsoft.EntityFrameworkCore;

namespace TestApp.Models;

public partial class TestAppContext : DbContext
{
    public TestAppContext()
    {
    }

    public TestAppContext(DbContextOptions<TestAppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Additon> Additons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-FM1HGUR\\MSSQLSERVER2019;Database=TestApp;Persist Security Info=False;User ID=sa;Password=sys@123;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Additon>(entity =>
        {
            entity.ToTable("Additon");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
