using C42_G02_EF02.Data;
using Microsoft.EntityFrameworkCore;

namespace C42_G02_EF02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();
            
            var employees = context.Employees.Where(E => E.Age > 20).ToList();


        }
    }
}
