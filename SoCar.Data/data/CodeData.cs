using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoCar.Data
{
    public class CodeData : EntityData<Code>
    {
        public Code Get(int codeId)
        {
            SocarEntities context = CreateContext();
            return context.Codes.FirstOrDefault(x => x.CodeId == codeId);
        }

        public List<Code> GetByCodeCategoryId(int codeCategoryId)
        {
            //SocarEntities context = CreateContext();
            //return context.Codes.set(x => x.CodeCategoryId == codeCategoryId);

            var context = CreateContext();

            var query = from x in context.Codes
                        where x.CodeCategoryId == codeCategoryId
                        select x;
            /*new { Code = x, Id = x.CodeCategory.CodeCategoryId };*/
            return query.ToList();
            
        }
    }
}
