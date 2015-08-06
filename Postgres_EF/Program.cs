using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Postgres_EF.EF;
using Postgres_EF.EF.Entities;

namespace Postgres_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DBContext();

            var pets = db.Pets;
            foreach (var p in pets)
            {
                //db.Pets.Remove(p);
                Console.WriteLine(p.Name);

            }
            Console.WriteLine("Finished");

            Console.Read();
        }
    }
}
