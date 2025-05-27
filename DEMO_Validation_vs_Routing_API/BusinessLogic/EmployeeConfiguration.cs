using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Alice Johnson",
                    Age = 30,
                    Position = "Software Engineer",
                    CompanyId = Guid.Parse("11111111-1111-1111-1111-111111111111") 
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Bob Smith",
                    Age = 28,
                    Position = "Data Analyst",
                    CompanyId = Guid.Parse("11111111-1111-1111-1111-111111111111") 
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Charlie Brown",
                    Age = 35,
                    Position = "Project Manager",
                    CompanyId = Guid.Parse("22222222-2222-2222-2222-222222222222") 
                }
            );
        }
    }

}
