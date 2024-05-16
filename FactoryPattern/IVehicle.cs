using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public void Drive();

    }
}
