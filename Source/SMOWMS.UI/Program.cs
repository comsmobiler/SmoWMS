using SMOWMS.UI;
using System;
using System.Windows.Forms;

static class Program
{
    /// <summary>
    /// 应用程序的主入口点。
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        AutomapperConfig.Init();
        Application.Run(new frmMain());
    }

}