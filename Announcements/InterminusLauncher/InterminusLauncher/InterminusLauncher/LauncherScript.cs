using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace InterminusLauncher
{
    class LauncherScript
    {
        public static void playGame()
        {
            Process.Start("The Overlooked.exe");
        }
        public static void launchwebsite(string url)
        {
            Process.Start(url);
        }
    }
}
