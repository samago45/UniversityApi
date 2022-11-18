using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAccess
{
    public class UniversitiDBContext:DbContext
    {
        public UniversitiDBContext(DbContextOptions<UniversitiDBContext>options):
            base(options)
        { }

        //Todo: add DbSets (tables of our Data base)
        public DbSet<User>? Users { get; set; }
        public DbSet<Curso>? Cursos { get; set; }
    }
}
