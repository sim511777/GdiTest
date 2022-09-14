using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GdiTest {
    public partial class FormMain : Form {
        private Point pt;

        public FormMain() {
            InitializeComponent();
            
            chkOpaque_CheckedChanged(null, null);
        }

        private void FormMain_Paint(object sender, PaintEventArgs e) {
            e.Graphics.FillEllipse(Brushes.Red, pt.X - 100 - 20, pt.Y - 100 - 20, 200, 200);
            e.Graphics.FillEllipse(Brushes.Green, pt.X - 100 - 20, pt.Y - 100 + 20, 200, 200);
            e.Graphics.FillEllipse(Brushes.Blue, pt.X - 100 + 20, pt.Y - 100 + 20, 200, 200);
            e.Graphics.FillEllipse(Brushes.Yellow, pt.X - 100 + 20, pt.Y - 100 - 20, 200, 200);
            Console.WriteLine($"Draw to ({pt.X},{pt.Y})");
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e) {
            if (!e.Button.HasFlag(MouseButtons.Left))
                return;
            pt = e.Location;
            Invalidate();
        }

        private void chkOpaque_CheckedChanged(object sender, EventArgs e) {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, chkOptimizedDoubleBuffer.Checked);    // 더블버퍼링
            SetStyle(ControlStyles.UserPaint, chkUserPaint.Checked);                            // 자체적으로 그림
            SetStyle(ControlStyles.AllPaintingInWmPaint, chkAllPaintingInWmPaint.Checked);      // WM_ERASEBKGND 무시
            SetStyle(ControlStyles.Opaque, chkOpaque.Checked);                                  // 배경색 칠하지 않음
        }
    }
}
