using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppStudent.Models
{
    public class AppStudentContext : DbContext
    {
        public AppStudentContext (DbContextOptions<AppStudentContext> options)
            : base(options)
        {
        }

        public DbSet<AppStudent.Models.MyStud> MyStud { get; set; }
    }
}
