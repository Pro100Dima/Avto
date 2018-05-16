using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoPark.DAL.Modules
{
    public class Project
    {
        public string NameProject { get; set; }
        public List<Mawine> Mawines = new List<Mawine>();
        public void PrintInfo()
        {
            Console.WriteLine("Project :{0}", NameProject);
            foreach (Mawine item in Mawines)
            {
                Console.WriteLine("-----------------------------");
                item.PrintInfo();
            }
        }
    }
}
