using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team("персики", "ул.колонцова 8");
            team.AddPayer(new Payer("Матвей", "Про"));
            team.AddPayer(new Payer("Даня", "нуб"));
            team.AddPayer(new Payer("Вася", "Норм"));
            team.AddPayer(new Payer("Коля", "Про"));
            team.ShowAll();
            Console.ReadLine();
        }
    }
}