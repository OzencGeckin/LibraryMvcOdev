using Microsoft.EntityFrameworkCore;

namespace LibraryMvcOdev_1.Models.ContextClasses
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> opt):base(opt)
        {
            
        }
    }
}
