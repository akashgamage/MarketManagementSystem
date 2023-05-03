
namespace Mini_Market_Management_System
{
    partial class SpalshForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpalshForm));
            this.label1 = new System.Windows.Forms.Label();
            this.myProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label_logout = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(140, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "MARKET MANGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // myProgressBar
            // 
            this.myProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.myProgressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myProgressBar.BackgroundImage")));
            this.myProgressBar.Location = new System.Drawing.Point(270, 118);
            this.myProgressBar.Name = "myProgressBar";
            this.myProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.myProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.myProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.myProgressBar.ShadowDecoration.Parent = this.myProgressBar;
            this.myProgressBar.Size = new System.Drawing.Size(227, 230);
            this.myProgressBar.TabIndex = 3;
            this.myProgressBar.UseTransparentBackground = true;
            this.myProgressBar.ValueChanged += new System.EventHandler(this.myProgressBar_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2CustomGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2CustomGradientPanel1.BackgroundImage")));
            this.guna2CustomGradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2CustomGradientPanel1.Controls.Add(this.label_logout);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Blue;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(-2, -205);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(776, 805);
            this.guna2CustomGradientPanel1.TabIndex = 34;
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.BackColor = System.Drawing.Color.Transparent;
            this.label_logout.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logout.ForeColor = System.Drawing.Color.White;
            this.label_logout.Location = new System.Drawing.Point(23, 740);
            this.label_logout.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label_logout.Name = "label_logout";
            this.label_logout.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label_logout.Size = new System.Drawing.Size(107, 33);
            this.label_logout.TabIndex = 32;
            this.label_logout.Text = "Logout";
            // 
            // SpalshForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(770, 395);
            this.Controls.Add(this.myProgressBar);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpalshForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpalshForm";
            this.Load += new System.EventHandler(this.SpalshForm_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar myProgressBar;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label_logout;
    }
}