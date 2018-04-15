using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeNetStatManager
{
    public partial class Main : Form
    {
        //String path = Environment.CurrentDirectory + "\\" + "config.txt";
        String path = @"C:\Projects\FakeNetStat\FakeNetStat\bin\Debug\config.txt";

        public Main()
        {
            InitializeComponent();
        }

        private void btnGenerateConfig_Click(object sender, EventArgs e)
        {
            
            List<string> configInfo = new List<string>();
            configInfo.Add(txtTestInput.Text);

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@path))
            {
                foreach (string line in configInfo)
                {
                   file.WriteLine(line);
                }
            }
        }
    }
}
