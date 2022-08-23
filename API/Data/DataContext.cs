using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions option) : base(option)
        {
            
        }

        public  DbSet<AppUser> Users {set; get;}
    }
}