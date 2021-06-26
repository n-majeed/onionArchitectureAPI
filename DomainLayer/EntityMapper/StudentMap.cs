using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.EntityMapper
{
   public class StudentMap: IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id)
                   .HasName("pk_studentid");

            builder.Property(x => x.Id).ValueGeneratedOnAdd()
                .HasColumnName("id").HasColumnType("INT");

            builder.Property(x => x.name).HasColumnName("name")
                   .HasColumnType("NVARCHAR(100)")
                   .IsRequired();

            builder.Property(x => x.rollNo)
              .HasColumnName("RollNo")
                 .HasColumnType("INT")
                 .IsRequired();

            builder.Property(x => x.marks)
            .HasColumnName("Marks")
               .HasColumnType("INT")
               .IsRequired();

            builder.Property(x => x.CreatedDate)
              .HasColumnName("created_date")
                 .HasColumnType("datetime");
            builder.Property(x => x.ModifiedDate)
              .HasColumnName("modified_date")
                 .HasColumnType("datetime");
            builder.Property(x => x.IsActive)
              .HasColumnName("is_active")
                 .HasColumnType("bit");
        }
    }
}
