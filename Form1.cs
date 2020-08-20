using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using JsonJsonMeniShchonochiSnutsya.Classes;
using System.Windows.Forms.VisualStyles;

namespace JsonJsonMeniShchonochiSnutsya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pathToWrite = new StreamWriter(@"F:\Test GL\JsonJsonMeniShchonochiSnutsya\Results\JsonJsonMeniShchonochiSnutsya.json", false, System.Text.Encoding.Default);
            string dirName = textBox1.Text;
            DirectoryInfo dirInfo;
            while (true)
            {
                dirInfo = new DirectoryInfo(dirName);
                if (dirInfo.Exists)
                    break;
                MessageBox.Show($"I cant see directory: '{dirName}' in your file system, please try again!");
                textBox1.Clear();
                break;
            }
            Folder folder = Classes.Сalculation.CreateFolder(dirInfo);
            string data = JsonConvert.SerializeObject(folder, Formatting.Indented);
            pathToWrite.WriteLine(data); 
            MessageBox.Show("The application will close to open folder containing result json file, thank you for your attention!");
            System.Diagnostics.Process.Start(@"F:\Test GL\JsonJsonMeniShchonochiSnutsya\Results\");
            Application.Exit();
        }
    }
}
