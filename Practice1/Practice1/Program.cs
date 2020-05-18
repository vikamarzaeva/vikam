using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class Program
    {
        public static string Main(string[] args)
        {
            string txt="my pasion";            
            if (txt!="")
            {
                Console.WriteLine("Спасибо, что ввели текст!");
                if (txt.Length>10)
                {
                    Console.WriteLine("Ого, как много букв!");
                }
                else
                {
                    Console.WriteLine("Вот так достаточно!");
                }
            } 
            else
            {
                Console.WriteLine("Жаль, что ничего не ввели");
                
            }
            Console.ReadKey();
        }
    }
}
