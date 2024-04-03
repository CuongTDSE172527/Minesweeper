using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoMin
{
    internal static class Program
    {
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*LoadGame();*/
            diffForm = new DoKho();
            Application.Run(diffForm);
        }
        private static Form1 gameForm;
        private static DoKho diffForm;

       public static void A()
       {
            
            if (diffForm.SelectedDifficulty != 0)
            {
                gameForm = new Form1(diffForm.SelectedDifficulty);
                gameForm.ShowDialog();
            }
            else
            {
                // If no difficulty is selected, you can handle it accordingly
                MessageBox.Show("No difficulty selected. Exiting application.");
            }
        }

        public static void RestartGame()
        {
            Application.Restart();
        }
    }
}
