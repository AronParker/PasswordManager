using System;
using System.Windows.Forms;
using PasswordManager.Forms;
using System.Linq;
using PasswordManager.Controller;

namespace PasswordManager
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var controller = new MainFormController();
            controller.Run();
        }
    }
}
