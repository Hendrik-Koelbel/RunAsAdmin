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

        #region  Bind textbox custom source
        public static void SetDataSource(ComboBox comboBox, params string[] stringArray)
        {
            if (stringArray != null)
            {
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                foreach (var item in stringArray)
                {
                    col.Add(item);
                }
                comboBox.DataSource = col;
            }
            else
            {
                return;
            }
        }
        #endregion

        #region Get all Domains as string list
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

        #region Get all Users as string list
        public static List<string> GetAllUsers()
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

        #region Placeholder
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        [DllImport("user32.dll")]
        private static extern bool GetComboBoxInfo(IntPtr hwnd, ref COMBOBOXINFO pcbi);
        [StructLayout(LayoutKind.Sequential)]

        private struct COMBOBOXINFO
        {
            public int cbSize;
            public RECT rcItem;
            public RECT rcButton;
            public UInt32 stateButton;
            public IntPtr hwndCombo;
            public IntPtr hwndItem;
            public IntPtr hwndList;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        public static void Placeholder(Control control, string placeholder)
        {
            if (control is ComboBox)
            {
                COMBOBOXINFO info = GetComboBoxInfo(control);
                SendMessage(info.hwndItem, EM_SETCUEBANNER, 0, placeholder);
            }
            else
            {
                SendMessage(control.Handle, EM_SETCUEBANNER, 0, placeholder);
            }
        }

        private static COMBOBOXINFO GetComboBoxInfo(Control control)
        {
            COMBOBOXINFO info = new COMBOBOXINFO();
            //a combobox is made up of three controls, a button, a list and textbox;
            //we want the textbox
            info.cbSize = Marshal.SizeOf(info);
            GetComboBoxInfo(control.Handle, ref info);
            return info;
        }
        #endregion
    }
}
