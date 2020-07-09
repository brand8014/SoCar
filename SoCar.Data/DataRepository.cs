using SoCar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoCar.Data
{
    public class DataRepository
    {
        public static CarData Car { get; } = new CarData();
        public static CarTypeData CarType { get; } = new CarTypeData();
        public static CodeData Code { get; } = new CodeData();
        public static CustomerData Customer { get; } = new CustomerData();
        public static DefectData Defect { get; } = new DefectData();
        public static EventData Event { get; } = new EventData();
        public static InsuranceData Insurance { get; } = new InsuranceData();
        public static LocationData Location { get; } = new LocationData();
        public static RentData Rent { get; } = new RentData();

        public static LoginData Login { get; } = new LoginData();


    }
}
