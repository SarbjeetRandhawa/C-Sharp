using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Iquerable
{
    class Db : DbContext
    {
        public DbSet<User> users { get; set; }
    }

    class User
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            using var db = new Db();

            IQueryable<User> q = db.users.Where(e => e.name.StartsWith('A'));

            foreach(var i in q)
            {
                Console.WriteLine(i);
            }
        }
    } 
}