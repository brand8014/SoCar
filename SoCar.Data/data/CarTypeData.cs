
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SoCar.Data
{
    public class CarTypeData : EntityData<CarType>
    {
        public CarType Get(int carTypeId)
        {
            SocarEntities context = CreateContext();
            return context.CarTypes.FirstOrDefault(x => x.CarTypeId == carTypeId);
        }
        
       
        
    }
}
