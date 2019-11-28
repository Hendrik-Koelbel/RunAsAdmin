using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunAs
{
    public static class Helper
    {
        #region Window to front
        [DllImport("User32.dll")]
        public static extern int SetForegroundWindow(int hWnd); 
        #endregion


        #region Placeholder
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        public static void TextboxPlaceholder(TextBox textBox, string placeholder)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, placeholder);
        }
        #endregion

        #region  Set textbox custom source
        public static void TextBoxCustomSource(TextBox textBox, params string[] stringArray)
        {
            if (stringArray != null)
            {
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                foreach (var item in stringArray)
                {
                    col.Add(item);
                }
                textBox.AutoCompleteCustomSource = col;
            }
            else
            {
                return;
            }
        }
        #endregion

        #region 
        public static List<string> GetAllDomains()
        {
            using (var forest = Forest.GetCurrentForest())
            {
                var domainList = new List<string>();
                domainList.Add(Environment.MachineName);
                foreach (Domain domain in forest.Domains)
                {
                    domainList.Add(domain.Name);
                    domain.Dispose();
                }

                return domainList;
            }
        }
        #endregion
    }
}
