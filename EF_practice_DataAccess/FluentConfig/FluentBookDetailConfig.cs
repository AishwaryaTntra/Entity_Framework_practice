using Ef_practice_Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF_practice_DataAccess.FluentConfig
{
    public class FluentBookDetailConfig : IEntityTypeConfiguration<Fluent_BookDetail>
    {

        public void Configure(EntityTypeBuilder<Fluent_BookDetail> modelBuilder)
        {
            // table name
            modelBuilder.ToTable("Fluent_BookDetails");

            //column name
            modelBuilder.Property(u => u.NumberOfChapters).HasColumnName("NoOfChapters");
            
            //validation
            modelBuilder.Property(u => u.NumberOfChapters).IsRequired();
            
            
            modelBuilder.HasKey(u => u.BookDetail_Id);
            modelBuilder.HasOne(b => b.Book).WithOne(b => b.BookDetail).HasForeignKey<Fluent_BookDetail>("Book_Id");
        }
    }
}
