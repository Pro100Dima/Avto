using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoPark.DAL.Modules
{
    public enum TypeMashine {Ecscovator, Grader, Traktor}
    public class Mawine
    {
        public string Model { get; set; }
        public DateTime GodVypuska { get; set; }
        public TypeMashine TypeMasine { get; set; }
        public int GosNomer { get; set; }
        public List<Component> Components = new List<Component>();
        public void PrintInfo()
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("-> {0}\t {1}god vypuska", Model, GodVypuska.Year);
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Component item in Components)
            {
                Console.WriteLine("--> {0} ", item.NameComponent);
            }
        }
    }
}
