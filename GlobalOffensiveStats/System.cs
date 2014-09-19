using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GlobalOffensiveStats
{
    class CSGOAPP
    {
        [STAThread]
        public static void Main()
        {
            GlobalOffensiveStats.App app = new GlobalOffensiveStats.App();
            app.InitializeComponent();
            app.Run();
        }
    }
}