using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wuerfelspiel
{
    public partial class Uc_wuerfel : UserControl
    {
        Rectangle[] corners = new Rectangle[9];
        int count = 1;
        public Uc_wuerfel()
        {
            InitializeComponent();
        }

        private void Uc_wuerfel_Load(object sender, EventArgs e)
        {
            double h = Size.Height;
            double w = Size.Width;

            double hmulti = 0;
            for (int i = 0; i < corners.Length; i++)
            {
                corners[i].X = (int)((w * 0.33333333) * (i % 3));
                corners[i].Y = (int)(h * 0.33333333 * hmulti);
                corners[i].Size = new Size((int)(w * 0.33333333), (int)(h * 0.33333333));
                
                if (i % 3 == 2)
                    hmulti++;
            }
        }

        private void Uc_wuerfel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawRectangle(new Pen(Color.Black), new Rectangle(0, 0, ClientSize.Width - 1, ClientSize.Height - 1));

            if (count % 2 == 1)
                DrawRect(g, 4);

            if (count > 1)
            {
                DrawRect(g, 2);
                DrawRect(g, 6);
            }

            if (count > 3)
            {
                DrawRect(g, 0);
                DrawRect(g, 8);
            }

            if (count > 5)
            {
                DrawRect(g, 3);
                DrawRect(g, 5);
            }

        }

        private void DrawRect(Graphics graphics, int slot)
        {
            graphics.FillEllipse(new SolidBrush(Color.Red), corners[slot]);
        }

        private void Uc_wuerfel_DoubleClick(object sender, EventArgs e)
        {
            if (count == 6) {
                count = 0;
            }
            count++;
            Refresh();
        }
    }
}
