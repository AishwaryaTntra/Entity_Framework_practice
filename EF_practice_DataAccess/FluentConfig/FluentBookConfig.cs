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
    public class FluentBookConfig : IEntityTypeConfiguration<Fluent_Book>
    {

        public void Configure(EntityTypeBuilder<Fluent_Book> modelBuilder)
        {
            modelBuilder.Property(u => u.ISBN).HasMaxLength(20).IsRequired();
            modelBuilder.Ignore(u => u.PriceRange);
            modelBuilder.HasKey(u => u.BookId);
            modelBuilder.HasOne(b => b.Publisher).WithMany(u => u.Books).HasForeignKey(u => u.Publisher_Id);
        }
    }
}
