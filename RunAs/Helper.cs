using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RunAs
{
    public static class Helper
    {
        [DllImport("User32.dll")]
        public static extern int SetForegroundWindow(int hWnd);
    }
}
