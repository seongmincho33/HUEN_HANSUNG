using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PlannerDAL.Models;

public partial class ModelContext : DbContext
{
    public ModelContext()
    {
    }

    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbTest> TbTests { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseJet("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PlannerDB.accdb;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbTest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.ToTable("TB_TEST");

            entity.Property(e => e.Id)
                .HasColumnType("counter")
                .HasColumnName("ID");
            entity.Property(e => e.TestCol1)
                .HasMaxLength(255)
                .HasColumnName("TEST_COL1");
            entity.Property(e => e.TestCol2)
                .HasMaxLength(255)
                .HasColumnName("TEST_COL2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
