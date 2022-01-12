using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKategoriler.DataSource = db.Set<Categories>().Select(x => new
            {
                x.CategoryID,
                x.CategoryName

            }).ToList();
            cmbKategoriler.DisplayMember = "CategoryName";
            cmbKategoriler.ValueMember = "CategoryID";<
        }
    }
}
