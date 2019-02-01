using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentLibrary
{
    public class Project
    {

        public bool BodyNeedsToAdd;
        public bool SpringNeedsToAdd;
        public bool DamperNeedsToAdd; 

        public Project()
        {
            BodyNeedsToAdd = false;
            SpringNeedsToAdd = false;
            DamperNeedsToAdd = false;
        }
            

        public List<string> Bodies { get; set; }

        public List<string> Springs { get; set; }

        public List<string> Dampers { get; set; }

        public void AddBody(string Name)
        {
            if (BodyNeedsToAdd)
            {
                if(Bodies == null)
                {
                    Bodies = new List<string>();
                }

                Bodies.Add(Name);

                BodyNeedsToAdd = false;
            }
        }

        public void AddSpring(string Name)
        {
            if (SpringNeedsToAdd)
            {
                if(Springs == null)
                {
                    Springs = new List<string>();
                }

                Springs.Add(Name);

                SpringNeedsToAdd = false;
            }
        }

        public void AddDamper(string Name)
        {
            if (DamperNeedsToAdd)
            {
                if(Dampers == null)
                {
                    Dampers = new List<string>();
                }

                Dampers.Add(Name);

                DamperNeedsToAdd = false;
            }
        }
    }
}
