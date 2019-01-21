using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage
{
    public partial class Form5 : Form
    {
        public Form1 genitore;
        public Form5(Form1 unGenitore)
        {
            InitializeComponent();
            genitore = unGenitore;
            dataGridLog.Rows.Add("N° Veicoli totali");
            dataGridLog.Rows.Add("N° Auto");
            dataGridLog.Rows.Add("N° Furgoni");
            dataGridLog.Rows.Add("N° Moto");
            dataGridLog.Rows.Add("Tempo medio parcheggio dei veicoli");
            dataGridLog.Rows.Add("Tempo medio parcheggio delle auto");
            dataGridLog.Rows.Add("Tempo medio parcheggio dei furgoni");
            dataGridLog.Rows.Add("Tempo medio parcheggio delle moto");
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
