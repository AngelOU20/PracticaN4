using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PracticaN4.Models;

namespace PracticaN4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        
        


        public ApplicationDbContext(DbContextOptions dco ) : base(dco){

        }

    }

}