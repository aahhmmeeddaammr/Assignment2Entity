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
    internal class DepartmentConfugration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property("ID").UseIdentityColumn(1000,1);
            builder.Property("HiringDate").HasDefaultValueSql("GETDATE()");
            builder.HasOne(e=>e.Instructor).WithOne(i=>i.ManageDepartment).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
