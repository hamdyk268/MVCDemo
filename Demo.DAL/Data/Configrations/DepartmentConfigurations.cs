using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.DAL.Data.Configrations
{
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id).UseIdentityColumn(10, 10);
            builder.Property(D => D.Name).HasColumnType("varchar(20)");
            builder.Property(D => D.Code).HasColumnType("varchar(20)");
            builder.Property(D => D.CreatedOn).HasDefaultValueSql("GETDATE"); // بمجرد ما أعمل رن بتثبت التاريخ اللي حصل فيه رن أول مره
            builder.Property(D => D.LastModifiedOn).HasComputedColumnSql("GETDATE"); // كل ما نعمل رن بتغير التاريخ بتاعهاا بإستمرار
        }
    }
}
