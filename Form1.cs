using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void khoitaofont()
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                cmbfont.Items.Add(font.Name);
            }
        }
        private void khoitaosize()
        {
            int[] array = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach(var item in array)
            {
                cmbsize.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            khoitaofont();
            khoitaosize();
            cmbfont.SelectedItem = "Tahoma";
            cmbsize.SelectedItem = 14;
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                btndinhdang.ForeColor = fontDlg.Color;
                btndinhdang.Font = fontDlg.Font;
            }
        }

        
    }
}
