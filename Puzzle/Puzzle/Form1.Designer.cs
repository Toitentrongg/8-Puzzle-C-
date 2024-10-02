namespace Puzzle
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLen = new System.Windows.Forms.Button();
            this.btnTrai = new System.Windows.Forms.Button();
            this.btnPhai = new System.Windows.Forms.Button();
            this.btnXuong = new System.Windows.Forms.Button();
            this.TuNhap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DoThiBanDau = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OUT = new System.Windows.Forms.Button();
            this.AIGiai = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Step = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pause = new System.Windows.Forms.Button();
            this.InputKQ = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TrangThaiDich = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLen
            // 
            this.btnLen.BackColor = System.Drawing.Color.White;
            this.btnLen.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLen.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnLen.Location = new System.Drawing.Point(521, 437);
            this.btnLen.Margin = new System.Windows.Forms.Padding(4);
            this.btnLen.Name = "btnLen";
            this.btnLen.Size = new System.Drawing.Size(41, 52);
            this.btnLen.TabIndex = 9;
            this.btnLen.Text = "▲";
            this.btnLen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLen.UseVisualStyleBackColor = false;
            this.btnLen.Click += new System.EventHandler(this.btnLen_Click);
            // 
            // btnTrai
            // 
            this.btnTrai.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrai.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnTrai.Location = new System.Drawing.Point(479, 467);
            this.btnTrai.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrai.Name = "btnTrai";
            this.btnTrai.Size = new System.Drawing.Size(41, 52);
            this.btnTrai.TabIndex = 10;
            this.btnTrai.Text = "◀";
            this.btnTrai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrai.UseVisualStyleBackColor = true;
            this.btnTrai.Click += new System.EventHandler(this.btnTrai_Click);
            // 
            // btnPhai
            // 
            this.btnPhai.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhai.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnPhai.Location = new System.Drawing.Point(566, 467);
            this.btnPhai.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(41, 52);
            this.btnPhai.TabIndex = 11;
            this.btnPhai.Text = "▶";
            this.btnPhai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhai.UseVisualStyleBackColor = true;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // btnXuong
            // 
            this.btnXuong.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuong.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnXuong.Location = new System.Drawing.Point(521, 497);
            this.btnXuong.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuong.Name = "btnXuong";
            this.btnXuong.Size = new System.Drawing.Size(40, 52);
            this.btnXuong.TabIndex = 12;
            this.btnXuong.Text = "▼";
            this.btnXuong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXuong.UseVisualStyleBackColor = true;
            this.btnXuong.Click += new System.EventHandler(this.btnXuong_Click);
            // 
            // TuNhap
            // 
            this.TuNhap.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuNhap.ForeColor = System.Drawing.Color.MediumOrchid;
            this.TuNhap.Location = new System.Drawing.Point(419, 180);
            this.TuNhap.Margin = new System.Windows.Forms.Padding(4);
            this.TuNhap.Name = "TuNhap";
            this.TuNhap.Size = new System.Drawing.Size(184, 38);
            this.TuNhap.TabIndex = 13;
            this.TuNhap.Text = "Nhập Trạng Thái";
            this.TuNhap.UseVisualStyleBackColor = true;
            this.TuNhap.Click += new System.EventHandler(this.TuNhap_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(418, 119);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 53);
            this.button1.TabIndex = 14;
            this.button1.Text = "↻";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DoThiBanDau
            // 
            this.DoThiBanDau.AutoSize = true;
            this.DoThiBanDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoThiBanDau.Location = new System.Drawing.Point(597, 285);
            this.DoThiBanDau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DoThiBanDau.Name = "DoThiBanDau";
            this.DoThiBanDau.Size = new System.Drawing.Size(0, 24);
            this.DoThiBanDau.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(59, 119);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 333);
            this.panel1.TabIndex = 5;
            // 
            // OUT
            // 
            this.OUT.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OUT.ForeColor = System.Drawing.Color.Violet;
            this.OUT.Location = new System.Drawing.Point(59, 460);
            this.OUT.Margin = new System.Windows.Forms.Padding(4);
            this.OUT.Name = "OUT";
            this.OUT.Size = new System.Drawing.Size(106, 42);
            this.OUT.TabIndex = 16;
            this.OUT.Text = "Exit";
            this.OUT.UseVisualStyleBackColor = true;
            this.OUT.Click += new System.EventHandler(this.OUT_Click);
            // 
            // AIGiai
            // 
            this.AIGiai.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AIGiai.ForeColor = System.Drawing.Color.Yellow;
            this.AIGiai.Location = new System.Drawing.Point(545, 119);
            this.AIGiai.Margin = new System.Windows.Forms.Padding(4);
            this.AIGiai.Name = "AIGiai";
            this.AIGiai.Size = new System.Drawing.Size(52, 53);
            this.AIGiai.TabIndex = 18;
            this.AIGiai.Text = "🌟";
            this.AIGiai.UseVisualStyleBackColor = true;
            this.AIGiai.Click += new System.EventHandler(this.AIGiai_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(421, 401);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "STEP :";
            // 
            // Step
            // 
            this.Step.AutoSize = true;
            this.Step.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Step.Location = new System.Drawing.Point(494, 401);
            this.Step.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(0, 24);
            this.Step.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(420, 356);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tình trạng : ";
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.Location = new System.Drawing.Point(535, 356);
            this.lbTrangThai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(0, 24);
            this.lbTrangThai.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Playbill", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.HotPink;
            this.label3.Location = new System.Drawing.Point(62, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 55);
            this.label3.TabIndex = 9;
            this.label3.Text = "Puzzle Game (づ￣ ³￣)づ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(418, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Trạng thái ban đầu :";
            // 
            // pause
            // 
            this.pause.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.pause.Location = new System.Drawing.Point(479, 119);
            this.pause.Margin = new System.Windows.Forms.Padding(4);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(51, 53);
            this.pause.TabIndex = 24;
            this.pause.Text = "❚❚";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // InputKQ
            // 
            this.InputKQ.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputKQ.ForeColor = System.Drawing.Color.MediumOrchid;
            this.InputKQ.Location = new System.Drawing.Point(419, 236);
            this.InputKQ.Margin = new System.Windows.Forms.Padding(4);
            this.InputKQ.Name = "InputKQ";
            this.InputKQ.Size = new System.Drawing.Size(184, 38);
            this.InputKQ.TabIndex = 25;
            this.InputKQ.Text = "Nhập Kết Quả ";
            this.InputKQ.UseVisualStyleBackColor = true;
            this.InputKQ.Click += new System.EventHandler(this.InputKQ_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(421, 322);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Trạng thái đích:";
            // 
            // TrangThaiDich
            // 
            this.TrangThaiDich.AutoSize = true;
            this.TrangThaiDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrangThaiDich.Location = new System.Drawing.Point(573, 320);
            this.TrangThaiDich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TrangThaiDich.Name = "TrangThaiDich";
            this.TrangThaiDich.Size = new System.Drawing.Size(0, 24);
            this.TrangThaiDich.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(791, 579);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TrangThaiDich);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InputKQ);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTrangThai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Step);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AIGiai);
            this.Controls.Add(this.OUT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DoThiBanDau);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TuNhap);
            this.Controls.Add(this.btnXuong);
            this.Controls.Add(this.btnPhai);
            this.Controls.Add(this.btnTrai);
            this.Controls.Add(this.btnLen);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "8-PUZZLE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLen;
        private System.Windows.Forms.Button btnTrai;
        private System.Windows.Forms.Button btnPhai;
        private System.Windows.Forms.Button btnXuong;
        private System.Windows.Forms.Button TuNhap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DoThiBanDau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OUT;
        private System.Windows.Forms.Button AIGiai;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Step;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button InputKQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TrangThaiDich;
    }
}

