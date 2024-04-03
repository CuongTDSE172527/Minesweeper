using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoMin
{
    public partial class DoKho : Form
    {
        public int Dokho;
        public int SelectedDifficulty { get; private set; }

        public DoKho()
        {
            InitializeComponent();
            SelectedDifficulty = 0;
        }



        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (SelectedDifficulty > 0)
            {
                // Close the difficulty selection form
                this.Close();
            }
            else
            {
                // If no difficulty is selected, show a message
                MessageBox.Show("Xin hãy chọn độ khó trước khi vào chơi.");
            }
        }

        private void HandleDifficultyChoice()
        {
            // Check which radio button is selected
            if (radioButtonDe.Checked)
            {
                SelectedDifficulty = 1; // You can adjust the difficulty levels as needed
            }
            else if (radioButtonTrungBinh.Checked)
            {
                SelectedDifficulty = 2;
            }
            else if (radioButtonKho.Checked)
            {
                SelectedDifficulty = 3;
            }


            if (SelectedDifficulty > 0)
            {

                // Close the difficulty selection form
                this.Hide();
                Program.A();
            }
            else
            {
                // If no difficulty is selected, show a message
                MessageBox.Show("Xin hãy chọn độ khó.");
            }
        }

        private void Easy_CheckedChanged(object sender, EventArgs e)
        {
            HandleDifficultyChoice();
        }

        private void Medium_CheckedChanged(object sender, EventArgs e)
        {
            HandleDifficultyChoice();
        }

        private void Difficult_CheckedChanged(object sender, EventArgs e)
        {
            HandleDifficultyChoice();
        }

        public void ResetParameter()
        {
            radioButtonDe.Checked = false;
            radioButtonTrungBinh.Checked = false;
            radioButtonKho.Checked = false;
            SelectedDifficulty = 0;
        }
    }
}
