using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GlobalOffensiveStats.Constants;

namespace GlobalOffensiveStats.GUI
{
    class Window : Form
    {
        private Point lastClick;
        private List<Label> labels;

        public Window()
        {
            Initialization();
        }

        public void SetLabel(int index, string text)
        {
            labels[index].Text = text;
        }

        private void Initialization()
        {
            this.SuspendLayout();
            this.ClientSize = new Size(500, 500);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MouseMove += new MouseEventHandler(this.OnMouseMove);
            this.MouseDown += new MouseEventHandler(this.OnMouseDown);
            this.KeyPress += new KeyPressEventHandler(this.OnKeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

            labels = new List<Label>();
            StatNames names = new StatNames();

            for(int i = 0; i < 10; ++i)
            {
              labels.Add(new Label());
              labels[i].Width = 200;
              labels[i].Text = names.statNames[i];
              labels[i].Top = i * 45;
              labels[i].Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
              labels[i].BackColor = Color.FromKnownColor(KnownColor.Transparent);
              this.Controls.Add(labels[i]);
            }
                

        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            lastClick = new Point(e.X, e.Y);
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }
        
        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'q')
                Application.Exit();
        }

    }
}
