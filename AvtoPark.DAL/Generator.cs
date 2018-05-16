using AvtoPark.DAL.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoPark.DAL
{
    public class Generator
    {
        private Random r = new Random();
        public bool Gener(ref List<Project> Projects, out string message)
        {
            try
            {
                if (Projects == null)
                    Projects = new List<Project>();

                Projects.Add(new Project() { NameProject = "Varvarinskiy GOK" });
                Projects[0].Mawines = GenerMawines(out message);

                Projects.Add(new Project() { NameProject = "Karagandiskaya shahta" });
                Projects[1].Mawines = GenerMawines(out message);

                Projects.Add(new Project() { NameProject = "SS GOK" });
                Projects[2].Mawines = GenerMawines(out message);
                message = "Proekty dobavleny uspewno";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
        private List<Mawine> GenerMawines(out string message)
        {
            List<Mawine> Mashines = new List<Mawine>();
            for (int i = 0; i < 5; i++)
            {
                Mawine mawine = new Mawine();
                mawine.GodVypuska = DateTime.Now.AddMonths(r.Next(10,200) * (-1));
                mawine.GosNomer = r.Next(1000,9999);
                mawine.Model = "Model"+ r.Next(1,10);
                mawine.TypeMasine = (TypeMashine)r.Next(1, 3);
                mawine.Components = GenerComponent(out message);
                Mashines.Add(mawine);
            }
            message = "Mawiny sgenerirovalis";
            return Mashines;
        }
        private List<Component> GenerComponent(out string message)
        {
            List<Component> components = new List<Component>();
            for (int i = 0; i < 5; i++)
            {
                Component component = new Component();
                component.IdComponent = r.Next();
                component.NameComponent = (Parts)r.Next(1,4);
                components.Add(component);
            }
            message = "Componenty sgenerirovalis";
            return components;
        }
    }
}
