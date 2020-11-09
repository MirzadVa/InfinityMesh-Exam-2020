using Internship_Exam_2020.dal.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_Exam_2020.dal.Configuration
{
    public class BlogConfiguration : BaseEntityConfiguration<Blog>
    {
        public override void Configure(EntityTypeBuilder<Blog> builder)
        {
            base.Configure(builder);
            builder.Property(t => t.Title);
            builder.Property(s => s.Summary);
            builder.Property(c => c.Content);

            builder
                .HasOne(u => u.User)
                .WithMany(b => b.Blogs)
                .HasForeignKey(u => u.UserId);
        }
    }
}
