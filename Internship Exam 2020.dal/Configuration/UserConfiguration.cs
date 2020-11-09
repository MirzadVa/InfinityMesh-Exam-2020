using Internship_Exam_2020.dal.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_Exam_2020.dal.Configuration
{
    public class UserConfiguration : BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.Property(n => n.Name);
            builder.Property(a => a.Age);
            builder.Property(e => e.Email);

            builder
                .HasMany(b => b.Blogs)
                .WithOne(u => u.User)
                .HasForeignKey(u => u.UserId);
        }
    }
}
