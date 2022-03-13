using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Car_game
{
    
    class MeniuPrincipal: Form
    {
        private Form1 joc;
        private Button restart;
        private System.ComponentModel.IContainer components = null;

        public MeniuPrincipal()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeniuPrincipal));

            restart = new Button();
            this.SuspendLayout();

            this.restart.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restart.Location = new System.Drawing.Point(160, 253);
            this.restart.Size = new System.Drawing.Size(154, 46);
            this.restart.TabIndex = 19;
            this.restart.Visible = true;
            this.restart.Name = "restart";
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restartOnClick);
            this.Controls.Add(this.restart);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void restartOnClick(object sender,EventArgs e)
        {
            joc = new Form1();
            joc.Show();
        }

    }
}
