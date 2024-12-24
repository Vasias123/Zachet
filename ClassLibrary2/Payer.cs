using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Payer
    {
    public string Name { get; set; }
    public string Description { get; set; }
    public Payer(string name, string description) 
    {
    Name = name;
    Description = description;
    }
        public void Show()
        {
            Console.WriteLine($"Имя: {Name}, Описание:{Description}");
        }
        
    }
}
