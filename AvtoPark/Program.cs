using AvtoPark.DAL;
using AvtoPark.DAL.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator generator = new Generator();
            List<Project> projects = null;
            string message;
            if (!generator.Gener(ref projects, out message))
            {
                Console.WriteLine(message);
                return;
            }

            foreach (Project item in projects)
            {
                item.PrintInfo();
            }

            Console.WriteLine("vyberite project =");
            foreach (Project item in projects)
            {
                Console.WriteLine(" " + item.NameProject);
            }
            Project temp = null;
            do
            {

                Console.Write("->");
                string name = Console.ReadLine();

                temp = projects.FirstOrDefault(o => o.NameProject == name);
                if (temp != null) break;

                Console.WriteLine("proect ne naiden");
            } while (temp == null);
            Console.WriteLine("vyberite kriteriy poiska: 1 - GosNomer, 2 - Model");

            int choice = 0;
            do
            {
                Console.Write("->");
                Int32.TryParse(Console.ReadLine(), out choice);
            } while (choice != 1 || choice != 2);

            int gosNomer = 0;
            string modelMasine = "";
            Service service = new Service();
            Mawine findeMawine = null;

            switch (choice)
            {
                case 1:
                    {
                        Console.Write("vvedite gos nomer mawiny ->");
                        Int32.TryParse(Console.ReadLine(), out gosNomer);
                        findeMawine = service.Search(temp, gosNomer);
                    }
                    break;
                case 2:
                    {
                        Console.Write("vvedite model mawiny ->");
                        findeMawine = service.Search(temp, Console.ReadLine());
                    }
                    break;
            }
            if (findeMawine == null)
            {
                Console.WriteLine("Mawina ne naidena");
            }
            else findeMawine.PrintInfo();
        }
    }
}
