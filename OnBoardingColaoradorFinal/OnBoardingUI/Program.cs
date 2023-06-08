using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnBoardingUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new MenuPrincipal());
        }
    }
}
