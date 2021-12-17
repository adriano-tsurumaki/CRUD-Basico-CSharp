using CRUD___Adriano.Features;
using CRUD___Adriano.Features.Configuration;
using CRUD___Adriano.Features.Configuration.Login.Controller;
using CRUD___Adriano.Features.IoC;
using System;
using System.Windows.Forms;

namespace CRUD___Adriano
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FluentMap.InicializarMap();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfigNinject.Registrar(new SqlConexao());

            while(true)
            {
                var loginResultado = ConfigNinject.ObterInstancia<LoginController>().RetornarFormulario().ShowDialog();

                if (loginResultado == DialogResult.OK)
                    Application.Run(ConfigNinject.ObterInstancia<FrmPrincipal>());

                if (!LoginConfig.VoltarATelaDeLogin)
                {
                    Application.Exit();
                    break;
                }
            }
        }
    }
}
