using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Shared;

namespace WebApplication1.Server.Configurations.Entities
{
    public class MemoryConfiguration : IEntityTypeConfiguration<Memory_>
    {
        public void Configure(EntityTypeBuilder<Memory_> builder)
        {
            builder.HasData(

                new Memory_
                {
                    Id = 1,
                    Expression = "2+2",
                    Result = 4
                },

                new Memory_
                {
                    Id = 2,
                    Expression = "6*6",
                    Result = 36
                }

                ) ;
        }

        //public void Configure(EntityTypeBuilder<Memory_> builder)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
