using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGRecover
{
    public partial class Form1 : Form
    {
        string Default = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Telegram Desktop");
        string PathFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\TGR\Path.File";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(Default))
            {
                if (MessageBox.Show("Is this your current telegram installation path ?", "Default path found", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Path.Text = Default;
                else SetPath();
            }
            else SetPath();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            if (Path.Text != "Path :" && !string.IsNullOrWhiteSpace(Path.Text))
            {
                try
                {
                    if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\TGR\"))
                        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\TGR\");
                    File.WriteAllText(PathFile, Path.Text);
                    File.Move(Environment.CurrentDirectory + @"\Recover.exe", Environment.GetFolderPath(Environment.SpecialFolder.Startup));
                    MessageBox.Show("Done!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Select installation folder of telegram desktop");
                SetPath();
            }
        }

        private void Exit_Click(object sender, EventArgs e) => Application.Exit();

        private void SetPath()
        {
            if (Loader.ShowDialog() == DialogResult.OK)
                Path.Text = Loader.SelectedPath;
        }
    }
}
