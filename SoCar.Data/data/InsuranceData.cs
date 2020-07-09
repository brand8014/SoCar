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

        public List<Insurance> Search(int? insuranceId, int? companyCode, int? goodsCode)
        {
            SocarEntities context = CreateContext();

            var query = from x in context.Insurances
                        select x;

            if (insuranceId.HasValue)
                query = query.Where(x => x.InsuranceId == insuranceId);

            if (goodsCode.HasValue)
                query = query.Where(x => x.CompanyCode == companyCode);

            if (goodsCode.HasValue)
                query = query.Where(x => x.GoodsCode == goodsCode);


            return query.ToList();

        }
    }
}
