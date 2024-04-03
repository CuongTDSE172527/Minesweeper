using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DoMin
{

    public partial class Form1 : Form
    {

        //khai bao bien tao ra cac o do min bang btn
        Button[,] btnmin;
        int control = 0; //co 3 gia tri 0,1,-1
        int[,] a = new int[10, 10];
        int so_o_mo = 0;
        int somin = 20; // khoi tao so minh tong cong la 20, co nghi so o khong min la 80
        int currentSize = 0;
        int width = 30;
        public Form1(int difficultyLevel)
        {
            AdjustGameParameters(difficultyLevel);
            InitializeComponent();
            
            // Use the difficulty level as needed to adjust the game parameters
        }


        private void paldomin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Bammin(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    FlagMine(sender, e);
                    break;
                case MouseButtons.Left:
                    if (control == 0)
                    {
                        int x = 0;
                        int y = 0;
                        
                        x = ((Button)sender).Location.X;
                        y = ((Button)sender).Location.Y;
                        int i = 0, j = 0;
                        i = x / width;
                        j = y / width;
                        if (a[i, j] == 0)//Neu nut bam khong co min
                        {
                            mo_o(i, j);
                        }
                        else//co min
                        {
                            ((Button)sender).Text = "@";
                            ((Button)sender).BackColor = Color.Red;
                            control = -1;
                        }
                    }
                    if (control == 1)
                    {
                        lbkq.Text = "Người chơi thắng";
                        this.restartBtn.Visible = true;
                    }
                    else
                        if (control == -1)
                    {
                        lbkq.Text = "Người chơi thua";
                        this.restartBtn.Visible = true;
                    }
                    break;
            }
        }
        private void mo_o(int i, int j)
        {
            if (a[i, j] == 0)//Neu nut bam khong co min
            {
                if (btnmin[i, j].Text == "")
                {
                    so_o_mo++;
                    lbomo.Text = so_o_mo.ToString();

                    if (sominxungquanh(i, j) == 0)
                        btnmin[i, j].Text = " ";
                    else
                        btnmin[i, j].Text = sominxungquanh(i, j).ToString();
                    btnmin[i, j].BackColor = Color.Beige;
                    //mo cac o theo phuong hinh dau cong
                    //dung phuong thuc de quy
                    if (sominxungquanh(i, j) == 0)
                        mo_o_lancan(i, j);
                }
            }
        }
        private void mo_o_lancan(int i, int j)
        {
            //co 4 o lan can 
            if (i - 1 >= 0)//kiem tra o o tren
            {
                    mo_o(i-1, j);                
            }
            if (j - 1 >= 0) //kiem tra o ben trai
            {
                    mo_o(i, j-1); 
            }
            if (i + 1 < 10)//kiem tra o o duoi
            {
                    mo_o(i + 1, j);
            }
            if (j + 1 < 10) //kiem tra o ben phai
            {
                    mo_o(i, j + 1);
            }
        }

        private int sominxungquanh(int i, int j)
        {
            int kq = 0;
            //cong don thu nhat
            if(i > 0 & j > 0)
                kq += a[i - 1, j - 1];
            if (i > 0)
            {
                if ( j > 0)
                    kq += a[i - 1, j - 1];
                kq += a[i - 1, j];
                if(j<currentSize-1)
                    kq += a[i - 1, j + 1];
            }
            //cong dong thu 2
            if (j > 0)
            {
                kq += a[i, j - 1];
            }
            if (j < currentSize -1)
            {
                kq += a[i, j + 1];
            }
            //cong dong thu 3
            if(i<currentSize - 1)
            {
                if (j > 0)
                    kq += a[i + 1, j - 1];
                kq += a[i + 1, j];
                if (j < currentSize - 1)
                    kq += a[i + 1, j + 1];
            }

            return kq;
        }

        private void AdjustGameParameters(int difficultyLevel)
        {
            // You can customize this method to adjust the game parameters
            // based on the selected difficulty level.
            // For example, you can adjust the size of the game grid or the number of mines.
            switch (difficultyLevel)
            {
                case 1: // Easy
                    somin = 10;
                    currentSize = 9;
                    break;
                case 2: // Medium
                    somin = 20;
                    currentSize = 16;
                    break;
                case 3: // Hard
                    somin = 30;
                    currentSize = 24;
                    break;
                default:
                    // Handle unexpected difficulty level (optional)
                    MessageBox.Show("Độ khó không đúng, sử dụng độ khó mặc định.");
                    break;
                }
            }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FlagMine(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && control == 0)
            {
                int x = 0;
                int y = 0;
                
                x = ((Button)sender).Location.X;
                y = ((Button)sender).Location.Y;
                int i = x / width;
                int j = y / width;

                if (btnmin[i, j].Text == "")
                {
                    btnmin[i, j].Text = "F"; // Flag
                    btnmin[i, j].ForeColor = Color.Red;
                }
                else if (btnmin[i, j].Text == "F")
                {
                    btnmin[i, j].Text = ""; // Unflag
                    btnmin[i, j].ForeColor = SystemColors.ControlText;
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void restartBtn_Clicked(object sender, EventArgs e)
        {
            this.Close();
            Program.RestartGame();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //khoi tao vitri, kich thuoc cac o do min, them vao panel
            a = new int[currentSize, currentSize];
            btnmin = new Button[currentSize, currentSize];
            int i = 0;
            int j = 0;
            for (i = 0; i < currentSize; i++)
                for (j = 0; j < currentSize; j++)
                {
                    btnmin[i, j] = new Button();
                    btnmin[i, j].Width = width;//thiet lap chiu rong
                    btnmin[i, j].Height = width;//thiet lap chieu cao
                    btnmin[i, j].Location = new Point(i * width, j * width);//thiet lap vi tri cua nut
                    btnmin[i, j].Text = ""; // thiet lap nut khong hien thi hinh anh
                    btnmin[i, j].MouseUp += Bammin;//thietlap ham bam min,
                    paldomin.Controls.Add(btnmin[i, j]);//add vao pannel de hien len giao dien

                    a[i, j] = 0;
                }

            //khoi tao ham random.

            Random rnd = new Random();
            int dem = 0;
            while (dem < somin) //de co the chu dong thay doi so min 
            {
                
                i = rnd.Next(currentSize);// Creates a number 0 and 10
                j = rnd.Next(currentSize);
                if (a[i, j] == 0)//chua tao min 
                {
                    a[i, j] = 1;
                    dem++;
                }
                
            }
            lbsomin.Text = somin.ToString();
        }
    }
}
    