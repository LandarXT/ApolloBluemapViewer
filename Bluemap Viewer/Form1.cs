using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bluemap_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chromiumWebBrowser1.LoadUrl("http://66.11.114.90:8100/");
        }

        private void Overworldbtn_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.LoadUrl("http://66.11.114.90:8100/map.html");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.LoadUrl("http://66.11.114.90:8100/map.html#nether:-21:0:36:500:0:0:0:0:perspective");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.LoadUrl("http://66.11.114.90:8100/map.html#nether_roof:-21:0:36:500:0:0:0:0:perspective");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.LoadUrl("http://66.11.114.90:8100/map.html#end:0:0:0:500:0:0:0:0:perspective");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}