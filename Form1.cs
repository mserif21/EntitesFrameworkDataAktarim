using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitesFrameworkDataAktarım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tum_siparisler_Click(object sender, EventArgs e)
        {
           NORTHWNDEntities db=new NORTHWNDEntities();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.Orders.ToList();
        }

        private void ilk5_Click(object sender, EventArgs e)
        {
            NORTHWNDEntities can=new NORTHWNDEntities();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = can.Orders.Take(5).ToList();
        }
    }
}
