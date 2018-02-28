using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;

namespace FontCollections
{
    public partial class frmCollection : Form
    {
        private List<string> fontList = new List<string>();

        public frmCollection()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Search 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            InstalledFontCollection sysFont = new InstalledFontCollection();
            FontFamily[] sysFontFamilies = sysFont.Families;
            int Count = sysFontFamilies.Length;
            lvFonts.Items.Clear();
            fontList.Clear();
            for (int i = 0; i < Count; i++)
            {
                string FontName = sysFontFamilies[i].Name;
                fontList.Add(FontName);
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = FontName;
                lvFonts.Items.Add(lvItem);
            }
        }

        private void btnExportTxt_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var font in fontList)
            {
                sb.Append(font);
                sb.Append("_");
            }
            ClearTxt();
            string fonts = sb.ToString().TrimEnd(new char[] { '_' });
            File.WriteAllText("Fonts.txt",fonts); 
        }

        public void ClearTxt()
        {
            String appDir = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory,"Fonts.txt");
            FileStream stream = File.Open(appDir, FileMode.OpenOrCreate, FileAccess.Write);
            stream.Seek(0, SeekOrigin.Begin);
            stream.SetLength(0);
            stream.Close();
        }
    }
}
