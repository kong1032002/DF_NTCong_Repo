using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DF_NTCong_Repo_Core.Models;

public partial class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product_Table> Product_Table { get; set; }

    public virtual DbSet<Sinhvien> Sinhviens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-63UQ0FA\\MSSQLSEVER;Initial Catalog=DF;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product_Table>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Products__3213E83FC142A735");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Sinhvien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SINHVIEN__3214EC2758545D8C");

            entity.ToTable("SINHVIEN");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Hocphi)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HOCPHI");
            entity.Property(e => e.Khoahoc)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KHOAHOC");
            entity.Property(e => e.Ten)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TEN");
            entity.Property(e => e.Tuoi).HasColumnName("TUOI");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
