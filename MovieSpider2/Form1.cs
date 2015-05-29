using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieSpider2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            this.comboBox1.DataSource = youku.URLs;
        }
        Youku youku = new Youku();
        private void button1_Click(object sender, EventArgs e)
        {
            youku.URL = comboBox1.SelectedItem.ToString();
            comboBox1.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
            btn_Start.Enabled = false;
        }
        List<Entities.MovieInfo> list;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            list = new List<Entities.MovieInfo>();
            for (int i = 1; i < 30; i++)
            {
                var l = youku.GetMovieList(youku.getPageUrl(i));
                if (l.Count>0)
                {
                    backgroundWorker1.ReportProgress(i,"探测总共页数:");
                    list.AddRange(l);
                }
                else
                {
                    break;
                }
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < list.Count; i++)
            {
                var m = youku.GetMovie(list[i]);
                if (m!=null)
                {
                    list[i] = m;
                    sb.AppendLine(list[i].ToString());
                }
                else
                {

                }
                backgroundWorker1.ReportProgress((i + 1) * 100 / list.Count,  (i+1).ToString() + "/" + list.Count.ToString()  + "\r\n"+list[i].Title + "\r\n总进度%:");
            }

            var fn = System.DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + ".txt";
            System.IO.File.WriteAllText(fn, sb.ToString());

            MessageBox.Show("Done!\r\n" + fn);


        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label1.Text = (e.UserState as string) + e.ProgressPercentage;

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btn_Start.Enabled = true;
            comboBox1.Enabled = true;
        }

        private void btn_GotoWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(comboBox1.SelectedItem.ToString());
        }

 
    }
}
