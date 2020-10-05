using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFromUdemyApp
{
    public static class Utils
    {
        public static Process StartProcess(this ProcessStartInfo psi, bool useShellExecute = true)
        {
            psi.UseShellExecute = useShellExecute;
            return Process.Start(psi);
        }


    }
}
