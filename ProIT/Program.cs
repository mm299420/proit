using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProIT;

namespace ProIT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            RunAsync().GetAwaiter().GetResult();
        }

        private static async Task RunAsync()
        {
            var token = "1R23a2kkOUtRaPYhrVrAMAii6";
            var message = "Hello";
            AiApi ai = new AiApi(token);
            try
            {
                var response = await ai.SendMessage(message);
                MessageBox.Show(response);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
            }
        }
    }
}