using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher {
    public partial class LauncherForm : Form {
        private PictureBox logopicturebox;
        private Label namelabel;
        private Label copyrightlabel;
        private Label versionlabel;

        public LauncherForm(String namevalue, String imagelink,
                            String versionvalue, String copyrightvalue) {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1600, 900);
            this.BackColor = Color.FromArgb(30,30,30);

            Image logopictureboximage = Image.FromFile(imagelink);
            logopicturebox = new PictureBox();
            logopicturebox.Location = new Point(650, 194);
            logopicturebox.Size = new Size(300, 300);
            logopicturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            logopicturebox.Image = logopictureboximage;

            namelabel = new Label();
            namelabel.Location = new Point(0, 589);
            namelabel.Size = new Size(1600, 120);
            namelabel.TextAlign = ContentAlignment.MiddleCenter;
            namelabel.ForeColor = Color.White;
            namelabel.Font = new Font("Microsoft YaHei", 64);
            namelabel.Text = namevalue;

            versionlabel = new Label();
            versionlabel.Location = new Point(800, 870);
            versionlabel.Size = new Size(785, 15);
            versionlabel.TextAlign = ContentAlignment.MiddleRight;
            versionlabel.ForeColor = Color.FromArgb(175, 171, 171);
            versionlabel.Font = new Font("Microsoft YaHei", 8);
            versionlabel.Text = versionvalue;

            copyrightlabel = new Label();
            copyrightlabel.Location = new Point(15,870);
            copyrightlabel.Size = new Size(785, 15);
            copyrightlabel.TextAlign = ContentAlignment.MiddleLeft;
            copyrightlabel.ForeColor = Color.FromArgb(175, 171, 171);
            copyrightlabel.Font = new Font("Microsoft YaHei", 8);
            copyrightlabel.Text = copyrightvalue;

            this.Controls.Add(logopicturebox);
            this.Controls.Add(namelabel);
            this.Controls.Add(copyrightlabel);
            this.Controls.Add(versionlabel);
        }//func LauncherForm

        private void LauncherForm_Load(object sender, EventArgs e) {

        }//func LauncherForm_Load
    }//class LauncherForm : Form
}//namespace  Launcher