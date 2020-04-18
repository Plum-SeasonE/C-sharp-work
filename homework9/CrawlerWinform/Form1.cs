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

namespace CrawlerWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBegin_Click(object sender, EventArgs e)
        {
            Crawlerw myCrawler = new Crawlerw(textBoxURL.Text);
            new Thread(myCrawler.Crawl).Start();
        }

        
    }
}
