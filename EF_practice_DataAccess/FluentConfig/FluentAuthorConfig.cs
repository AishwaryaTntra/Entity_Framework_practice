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
    public class FluentAuthorConfig : IEntityTypeConfiguration<Fluent_Author>
    {

        public void Configure(EntityTypeBuilder<Fluent_Author> modelBuilder)
        {

            // validation
            modelBuilder.Property(u => u.FirstName).IsRequired();
            modelBuilder.Property(u => u.FirstName).HasMaxLength(50);
            modelBuilder.Property(u => u.LastName).IsRequired();
            
            // primary key
            modelBuilder.HasKey(u => u.Author_id);
            
            //not mapped 
            modelBuilder.Ignore(u => u.FullName);
        }
    }
}
