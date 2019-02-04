using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        private List<IVehicleComponent> _bodies;
        public List<IVehicleComponent> Bodies
        {
            get
            {
                if (_bodies == null)
                {
                    _bodies = new List<IVehicleComponent>();
                }

                return _bodies;
            }
        }
        private List<IVehicleComponent> _springs;
        public List<IVehicleComponent> Springs
        {
            get
            {
                if (_springs == null)
                {
                    _springs = new List<IVehicleComponent>();
                }

                return _springs;
            }
        }

        private List<IVehicleComponent> _dampers;
        public List<IVehicleComponent> Dampers
        {
            get
            {
                if (_dampers == null)
                {
                    _dampers = new List<IVehicleComponent>();
                }

                return _dampers;
            }

        }

        public void AddBody(IVehicleComponent component)
        {
            if (BodyNeedsToAdd && component.Type == VehicleComponentType.Body)
            {
                Bodies.Add(component);

                BodyNeedsToAdd = false;
            }
        }

        public void AddSpring(IVehicleComponent component)
        {
            if (SpringNeedsToAdd && component.Type == VehicleComponentType.Spring)
            {
                Springs.Add(component);

                SpringNeedsToAdd = false;
            }
        }

        public void AddDamper(IVehicleComponent component)
        {
            if (DamperNeedsToAdd && component.Type == VehicleComponentType.Damper)
            {
                Dampers.Add(component);

                DamperNeedsToAdd = false;
            }
        }

        public string GetValidName(VehicleComponentType type)
        {
            string name = type.ToString() + " ";

            switch (type)
            {
                case VehicleComponentType.Body:
                    {
                        name += (Bodies.Count + 1).ToString();
                    }
                    break;
                case VehicleComponentType.Spring:
                    {
                        name += (Springs.Count + 1).ToString();
                    }
                    break;
                case VehicleComponentType.Damper:
                    {
                        name += (Dampers.Count + 1).ToString();
                    }
                    break;
                default:
                    break;
            }

            return name;
        }

        public void Save()
        { }
    }
}
