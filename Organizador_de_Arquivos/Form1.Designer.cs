namespace Organizador_de_Arquivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            progressBar1 = new ProgressBar();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button6 = new Button();
            btnModoEscuro = new Button();
            PictureBox2 = new PictureBox();
            PictureBox3 = new PictureBox();
            button8 = new Button();
            pictureBoxClaro = new PictureBox();
            pictureBoxEscuro = new PictureBox();
            button9 = new Button();
            button10 = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClaro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEscuro).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            resources.ApplyResources(progressBar1, "progressBar1");
            progressBar1.BackColor = Color.White;
            progressBar1.ForeColor = Color.Lime;
            progressBar1.Name = "progressBar1";
            progressBar1.Click += ProgressBar1_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.Black;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = Color.Black;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // button5
            // 
            resources.ApplyResources(button5, "button5");
            button5.BackColor = Color.White;
            button5.Cursor = Cursors.Hand;
            button5.ForeColor = Color.Black;
            button5.Name = "button5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += Button5_Click;
            // 
            // button4
            // 
            resources.ApplyResources(button4, "button4");
            button4.Name = "button4";
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.BackColor = Color.White;
            button3.Cursor = Cursors.Hand;
            button3.ForeColor = Color.Black;
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button3_Click;
            // 
            // button6
            // 
            resources.ApplyResources(button6, "button6");
            button6.BackColor = Color.White;
            button6.Cursor = Cursors.Hand;
            button6.ForeColor = Color.Black;
            button6.Name = "button6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += Button6_Click;
            // 
            // btnModoEscuro
            // 
            resources.ApplyResources(btnModoEscuro, "btnModoEscuro");
            btnModoEscuro.BackColor = Color.White;
            btnModoEscuro.Cursor = Cursors.Hand;
            btnModoEscuro.ForeColor = Color.Black;
            btnModoEscuro.Name = "btnModoEscuro";
            btnModoEscuro.UseVisualStyleBackColor = false;
            btnModoEscuro.Click += BtnModoEscuro_Click_1;
            // 
            // PictureBox2
            // 
            resources.ApplyResources(PictureBox2, "PictureBox2");
            PictureBox2.BackColor = Color.Transparent;
            PictureBox2.Image = Properties.Resources._7dca539d_533d_45c6_a1c5_04e046cd21ac;
            PictureBox2.Name = "PictureBox2";
            PictureBox2.TabStop = false;
            PictureBox2.Click += PictureBox2_Click;
            // 
            // PictureBox3
            // 
            resources.ApplyResources(PictureBox3, "PictureBox3");
            PictureBox3.BackColor = Color.Transparent;
            PictureBox3.Image = Properties.Resources._7dca539d_533d_45c6_a1c5_04e046cd21ac;
            PictureBox3.Name = "PictureBox3";
            PictureBox3.TabStop = false;
            PictureBox3.Click += PictureBox3_Click;
            // 
            // button8
            // 
            resources.ApplyResources(button8, "button8");
            button8.BackColor = Color.White;
            button8.Cursor = Cursors.Hand;
            button8.ForeColor = Color.Black;
            button8.Name = "button8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += Button8_Click;
            // 
            // pictureBoxClaro
            // 
            resources.ApplyResources(pictureBoxClaro, "pictureBoxClaro");
            pictureBoxClaro.Image = Properties.Resources._9e6634b1_5630_451a_8e8c_af6535ff8b93;
            pictureBoxClaro.Name = "pictureBoxClaro";
            pictureBoxClaro.TabStop = false;
            pictureBoxClaro.Click += PictureBoxClaro_Click;
            // 
            // pictureBoxEscuro
            // 
            resources.ApplyResources(pictureBoxEscuro, "pictureBoxEscuro");
            pictureBoxEscuro.Image = Properties.Resources._13201fec_680e_4a50_9072_c2baec450eb0;
            pictureBoxEscuro.Name = "pictureBoxEscuro";
            pictureBoxEscuro.TabStop = false;
            pictureBoxEscuro.Click += pictureBoxEscuro_Click;
            // 
            // button9
            // 
            resources.ApplyResources(button9, "button9");
            button9.BackColor = Color.White;
            button9.Cursor = Cursors.Hand;
            button9.ForeColor = Color.Black;
            button9.Name = "button9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += Button9_Click;
            // 
            // button10
            // 
            resources.ApplyResources(button10, "button10");
            button10.Name = "button10";
            button10.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(btnModoEscuro);
            Controls.Add(PictureBox3);
            Controls.Add(PictureBox2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(progressBar1);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBoxClaro);
            Controls.Add(pictureBoxEscuro);
            Controls.Add(button10);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClaro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEscuro).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private Button button2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button6;
        private Button btnModoEscuro;
        private PictureBox PictureBox2;
        private PictureBox PictureBox3;
        private Button button8;
        private PictureBox pictureBoxClaro;
        private PictureBox pictureBoxEscuro;
        private Button button9;
        private Button button10;
    }
}
