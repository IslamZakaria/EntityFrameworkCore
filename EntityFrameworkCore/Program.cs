using System;

namespace EntityFrameworkCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();

            _context.SaveChanges();
        }
    }
}
