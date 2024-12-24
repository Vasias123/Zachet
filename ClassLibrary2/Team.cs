using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Team
    {
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Payer> Payers { get; set; }
    public Team(string name, string address) 
    {
    Name = name;
    Address = address;
    Payers = new List<Payer>();
    }
    public void AddPayer(Payer payer) 
    {
    Payers.Add(payer);
    }
    public void ShowAll()
    {
            Console.WriteLine($"Название команды: {Name}, Адрес: {Address}");
            foreach (var payer in Payers) 
            {
                payer.Show();
            }
    }
    }
}
