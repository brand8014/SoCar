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
                        select new { Insurance = x, CompanyName = x.Code.Item ,GoodsName = x.Code1.Item };

            if (companyCode.HasValue)
                query = query.Where(x => x.Insurance.CompanyCode==companyCode);

            if (goodsCode.HasValue)
                query = query.Where(x => x.Insurance.GoodsCode==goodsCode);

            var items = query.ToList();

            foreach (var x in items)
            {
                x.Insurance.CompanyName = x.CompanyName;
                x.Insurance.GoodsName = x.GoodsName;
            }
            return query.ToList().ConvertAll(x=> x.Insurance);

        }

    }
}
