using System.Threading;
using System.Windows.Forms;

namespace ExemploLogin.Views.Utils
{
    public static class LoginController
    {
        public static void ShowLoginView(this Form form)
        {
            var thread = new Thread(LoginRun);
            TrocarThread(thread, form);
        }
        public static void ShowPrincipalView(this Form form)
        {
            var thread = new Thread(PrincipalRun);
            TrocarThread(thread, form);
        }


        private static void PrincipalRun()
        {
            Run(new FrmPrincipal());
        }
        private static void LoginRun()
        {
            Run(new FrmLogin());
        }
        private static void Run(Form form)
        {
            Application.Run(form);
        }

        private static void TrocarThread(Thread newThread, Form formOldThread)
        {
            // Inicia nova Thread.
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();

            // Fecha formulário da Thread Anterior.
            formOldThread.Close();
        }
    }
}
