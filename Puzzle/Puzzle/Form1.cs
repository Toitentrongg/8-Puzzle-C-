using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Puzzle
{
    public partial class Form1 : Form
    {
        string source;
        int col;
        int row;
        public static List<int> LstDoThiBanDau = new List<int>();
        List<List<int>> DuongDi = new List<List<int>>();
        private int Buoc = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void TuNhap_Click(object sender, EventArgs e)
        {
            Buoc = 0;
            Step.Text = Buoc.ToString();
            LstDoThiBanDau.Clear();
            Form form = new NhapDoThi();
            form.ShowDialog();
            string lst = string.Join(" ", LstDoThiBanDau);
            DoThiBanDau.Text = lst;
            panel1.Controls.Clear();
            draw(LstDoThiBanDau);
            XetTrangThai();
        }
        // Hàm tuple trả về hai giá trị
        static (int, int) GetToaDoXY(int row, int col)
        {
            int x = 0, y = 0;
            if (row == 0)
            {
                y = 3;
                if (col == 0)
                {
                    x = 3;

                }
                if (col == 1)
                {
                    x = 113;
                }
                if (col == 2)
                {
                    x = 223;
                }
            }
            else if (row == 1)
            {
                y = 113;
                if (col == 0)
                {
                    x = 3;

                }
                else if (col == 1)
                {
                    x = 113;
                }
                else
                {
                    x = 223;
                }
            }
            else
            {
                y = 223;
                if (col == 0)
                {
                    x = 3;

                }
                else if (col == 1)
                {
                    x = 113;
                }
                else
                {
                    x = 223;
                }
            }
            return (x,y);
        }

        void draw (List<int>DoThi)
        {
            panel1.Controls.Clear();
            int index = 0; 
            foreach (int i in  DoThi) 
            {
                row = index / 3;
                col = index % 3;

                switch (i)
                {
                    case 1:
                        source = @"D:\AI\Pic\Hinh1.png";
                        break;
                    case 2:
                        source = @"D:\AI\Pic\Hinh2.png";
                        break;
                    case 3:
                        source = @"D:\AI\Pic\Hinh3.png";
                        break;
                    case 4:
                        source = @"D:\AI\Pic\Hinh4.png";
                        break;
                    case 5:
                        source = @"D:\AI\Pic\Hinh5.png";
                        break;
                    case 6:
                        source = @"D:\AI\Pic\Hinh6.png";
                        break;
                    case 7:
                        source = @"D:\AI\Pic\Hinh7.png";
                        break;
                    case 8:
                        source = @"D:\AI\Pic\Hinh8.png";
                        break;
                    case 0:
                        source = "";
                        break;
                }
                (int x, int y) = GetToaDoXY(row, col);
                PictureBox pictureBox = new PictureBox();
                pictureBox.ImageLocation = source;
                pictureBox.Size = new Size(104, 104);
                pictureBox.Location = new Point(x, y);
                pictureBox.Name = i.ToString();
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                panel1.Controls.Add(pictureBox);
                index++;
            }
        }
        void XetTrangThai()
        {
            if ((AI.HamKTtraHopLe(LstDoThiBanDau) && AI.HamKTtraHopLe(AI.KQ)) ||
            (AI.HamKTtraHopLe(LstDoThiBanDau) == false && AI.HamKTtraHopLe(AI.KQ) == false))
            {

                AIGiai.Enabled = true;
                lbTrangThai.Text = ("Có thể giải được");
            }
            else
            {

                AIGiai.Enabled = false;
                lbTrangThai.Text = ("Không thể giải được");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Buoc = 0;
            Step.Text = Buoc.ToString();
            LstDoThiBanDau.Clear();
            Random random = new Random();
            while (LstDoThiBanDau.Count < 9)
            {
                int randomNumber = random.Next(0, 9);
                if (!LstDoThiBanDau.Contains(randomNumber))
                {
                    LstDoThiBanDau.Add(randomNumber);
                }
            }
            string lst = string.Join(" ", LstDoThiBanDau);
            DoThiBanDau.Text = lst;

            panel1.Controls.Clear(); 
            draw(LstDoThiBanDau);
            XetTrangThai();
        }

        
        private void btnLen_Click(object sender, EventArgs e)
        {
            Buoc += 1;
            int temp = LstDoThiBanDau.IndexOf(0);
            if (temp - 3 < 0)
            {
                MessageBox.Show("Không thể di chuyển!", "Thông Báo");
            }
            else
            {
                AI.Swap(LstDoThiBanDau, temp, temp - 3);
            }
            string lst = string.Join(" ", LstDoThiBanDau);
            DoThiBanDau.Text = lst; 
            draw(LstDoThiBanDau);
            if (AI.WIN(LstDoThiBanDau))
            {
                MessageBox.Show("★YOU WIN!", "Congratulations <(‘o'<)");
            }
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            Buoc += 1;
            int temp = LstDoThiBanDau.IndexOf(0);
            if (temp == 0|| temp == 3 || temp == 6)
            {
                MessageBox.Show("Không thể di chuyển!", "Thông Báo");
            }
            else
            {
                AI.Swap(LstDoThiBanDau, temp, temp - 1);
            }
            string lst = string.Join(" ", LstDoThiBanDau);
            DoThiBanDau.Text = lst;
            draw(LstDoThiBanDau);
            if (AI.WIN(LstDoThiBanDau))
            {
                MessageBox.Show("★YOU WIN!", "Congratulations <(‘o'<)");
            }
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            Buoc += 1;
            int temp = LstDoThiBanDau.IndexOf(0);
            if (temp == 2 || temp == 5 || temp == 8)
            {
                MessageBox.Show("Không thể di chuyển!", "Thông Báo");
            }
            else
            {
                AI.Swap(LstDoThiBanDau, temp, temp +1);
            }
            string lst = string.Join(" ", LstDoThiBanDau);
            DoThiBanDau.Text = lst;
            draw(LstDoThiBanDau);
            if (AI.WIN(LstDoThiBanDau))
            {
                MessageBox.Show("★YOU WIN!", "Congratulations <(‘o'<)");
            }
        }

        private void btnXuong_Click(object sender, EventArgs e)
        {
            Buoc += 1;
            int temp = LstDoThiBanDau.IndexOf(0);
            if (temp + 3 > 8)
            {
                MessageBox.Show("Không thể di chuyển!", "Thông Báo");
            }
            else
            {
                AI.Swap(LstDoThiBanDau, temp, temp + 3);
            }
            string lst = string.Join(" ", LstDoThiBanDau);
            DoThiBanDau.Text = lst;
            draw(LstDoThiBanDau);
            if (AI.WIN(LstDoThiBanDau))
            {
                MessageBox.Show("★YOU WIN!", "Congratulations <(‘o'<)");
            }
        }

        private void OUT_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNO = MessageBox.Show("Bạn có chắc chắn bỏ cuộc ?", "8-Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Button == OUT && YesOrNO == DialogResult.Yes) Environment.Exit(0);
        }
        private void AIGiai_Click(object sender, EventArgs e)
        {
            Buoc = 0;
            DuongDi = AI.Astar(LstDoThiBanDau);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Buoc < DuongDi.Count) 
            {
                Step.Text = Buoc.ToString();
                draw(DuongDi[Buoc]);
                Buoc++; 
            }
            else
            {
                timer1.Stop();
            }
        }

        private void pause_Click(object sender, EventArgs e)
        {
            if (pause.Text == "❚❚")
            {
                btnLen.Visible = false;
                btnXuong.Visible = false;
                btnPhai.Visible = false;
                btnTrai.Visible = false;
                pause.Text = "▷";
            }
            else
            {
                btnLen.Visible = true;
                btnXuong.Visible = true;
                btnPhai.Visible = true;
                btnTrai.Visible = true;
                pause.Text = "❚❚";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string lst = string.Join(" ", AI.KQ);
            TrangThaiDich.Text = lst;
        }

        private void InputKQ_Click(object sender, EventArgs e)
        {
            AI.KQ.Clear();
            Form form = new NhapKetQua();
            form.ShowDialog();
            string lst = string.Join(" ", AI.KQ);
            TrangThaiDich.Text = lst;
            XetTrangThai();
        }
    }
}
