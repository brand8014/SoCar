using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoCar.Data
{
    public class InsuranceData : EntityData<Insurance>
    {
        public Insurance Get(int insuranceId)
        {
            SocarEntities context = CreateContext();
            return context.Insurances.FirstOrDefault(x => x.InsuranceId == insuranceId);
        }

        public List<Insurance> Search(int? insuranceId, string company, string goods)
        {
            SocarEntities context = CreateContext();

            var query = from x in context.Insurances
                        select x;

            if (insuranceId.HasValue)
                query = query.Where(x => x.InsuranceId == insuranceId);

            if (string.IsNullOrEmpty(company) == false)
                query = query.Where(x => x.Company == company);

            if (string.IsNullOrEmpty(goods) == false)
                query = query.Where(x => x.Goods == goods);


            return query.ToList();

        }
    }
}
