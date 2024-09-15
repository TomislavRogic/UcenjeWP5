using EdunovaAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace EdunovaAPP.Data
{
    public class EdunovaContext:DbContext
    {
        // sto je DbSet? 

        public EdunovaContext(DbContextOptions<EdunovaContext>opcije): base(opcije)
            
                
        {



        }

        public DbSet<Smjer> Smjerovi { get; set; } // ovo ce nam trebati za svaki projekt
    }
}
