using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GdiTest {
    public partial class FormMain : Form {
        private Point pt;

        public FormMain() {
            InitializeComponent();
        }

        private void pbx_MouseMove(object sender, MouseEventArgs e) {
            if (!e.Button.HasFlag(MouseButtons.Left))
                return;
            pt = e.Location;
            pbx.Invalidate();
        }

        private void pbx_Paint(object sender, PaintEventArgs e) {
            var br = Brushes.Red;
            var rect = new Rectangle(pt.X - 100, pt.Y - 100, 200, 200);
            e.Graphics.FillEllipse(br, rect);
            Console.WriteLine($"FillEllipse({br}, {rect})");
        }
    }
}
