using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public List<Insurance> Search(int? companyCode, int? goodsCode)
        {
            SocarEntities context = CreateContext();

            var query = from x in context.Insurances
                        select x;

            if (companyCode.HasValue)
                query = query.Where(x => x.CompanyCode==companyCode);

            if (goodsCode.HasValue)
                query = query.Where(x => x.GoodsCode==goodsCode);


            return query.ToList();

        }

    }
}
