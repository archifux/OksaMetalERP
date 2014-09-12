﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OxxoUserInterface.Uretim
{
    public partial class uretimAnaEkrani : Form
    {
        public uretimAnaEkrani()
        {
            InitializeComponent();
        }

        private void planlanmamışİşlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlanlanmamisSparisler ps = new PlanlanmamisSparisler();
            ps.Show();
        }

        private void planlanmışİşlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlanlanmisUrunler ps = new PlanlanmisUrunler();
            ps.Show();
        }

        private void üretimdekilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uretimdekiler u = new uretimdekiler();
            u.Show();
        }

        private void raporlamalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uretimRaporlar ur = new uretimRaporlar();
            ur.Show();
        }

        private void ürünEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.Show();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
