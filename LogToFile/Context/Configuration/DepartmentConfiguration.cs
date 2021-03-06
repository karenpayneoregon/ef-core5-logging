// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using LogToFile.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;

namespace LogToFile.Context
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> entity)
        {
            entity.ToTable("Department");

            entity.Property(e => e.DepartmentID).ValueGeneratedNever();

            entity.Property(e => e.Budget)
                .HasColumnType("money")
                .HasAnnotation("Relational:ColumnType", "money");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasAnnotation("Relational:ColumnType", "datetime");
        }
    }
}
