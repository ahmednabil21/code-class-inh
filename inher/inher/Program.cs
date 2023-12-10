using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            customer c1 = new customer();
            {
                c1.Name = "Ahmed";
                c1.Address = "Baghdad";
                c1.Phone = "07740240372";


                //c1.Printpersondata();

                EMP e1 = new EMP();
                e1.Name = "Ahmed";


                Console.WriteLine(e1.Name);
                Console.ReadLine();

                customer c2 = new customer();
                c2.Name = "ali";
                c2.Address = "iraq";
                c2.Phone = "07740240372";
                Console.Write(c2.Name + "    ");
                Console.WriteLine(c2.Address + "    ");
                Console.WriteLine(c2.Phone);
                Console.ReadLine();


            }
        }

    }
}
    

