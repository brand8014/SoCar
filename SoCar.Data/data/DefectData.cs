using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoCar.Data
{
    public class DefectData : EntityData<Defect>
    {
        public Defect Get(int defectId)
        {
            SocarEntities context = CreateContext();
            return context.Defects.FirstOrDefault(x => x.DefectId == defectId);
        }

        public int GetMaxId()
        {
            var context = CreateContext();

            var query = from x in context.Defects
                        orderby x.DefectId descending
                        select x.DefectId;

            return query.FirstOrDefault();
        }

        public void Delete(int key)
        {
            Defect defect = Get(key);

            if (defect == null)
                return;

            Delete(defect);
        }
    }
}
