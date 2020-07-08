using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoCar.Winform.Helpers
{
    public static class Helper
    {

        public static bool SureToDelete()
        {

            return XtraMessageBox.Show(
                    "레알?",
                    "질문",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                    ) == DialogResult.Yes;
        }
    }
}
