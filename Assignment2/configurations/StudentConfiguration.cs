using Assignment2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.configurations
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey("ID");
            builder.Property("ID").UseIdentityColumn(2024000,1)
                .IsRequired(true);
            builder.Property("FName")
                .IsRequired(true);
            builder.Property("LName")
                .IsRequired(true);
            builder.Property("Dep_Id").IsRequired(false);
        }
    }
}
