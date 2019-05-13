using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_fw_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SampleDatabaseEntities db = new SampleDatabaseEntities())
            {
                var query = from v in db.Veicolo
                            select v;

                foreach (Veicolo veicolo in query)
                {
                    Console.WriteLine($"{veicolo.IDVeicolo}, {veicolo.Marca} {veicolo.Modello}");
                }

            }
        }
    }
}
