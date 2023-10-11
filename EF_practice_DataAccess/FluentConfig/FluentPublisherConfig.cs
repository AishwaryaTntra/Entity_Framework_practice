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
    public class FluentPublisherConfig : IEntityTypeConfiguration<Fluent_Publisher>
    {

        public void Configure(EntityTypeBuilder<Fluent_Publisher> modelBuilder)
        {
            modelBuilder.HasKey(u => u.PublisherId);
            modelBuilder.Property(u => u.Name).IsRequired();
        }
    }
}
