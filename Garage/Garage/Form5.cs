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
            dataGridLog.Rows[7].Cells[0].Value = ("Tempo medio parcheggio delle moto");
            dataGridLog.Rows[0].DefaultCellStyle.BackColor = Color.Red;
            dataGridLog.Rows[0].Cells[1].Value = genitore.lg.nVeicoliTot;
            dataGridLog.Rows[1].DefaultCellStyle.BackColor = Color.Lime;
            dataGridLog.Rows[1].Cells[1].Value = genitore.lg.nAutoTot;
            dataGridLog.Rows[2].DefaultCellStyle.BackColor = Color.Yellow;
            dataGridLog.Rows[2].Cells[1].Value = genitore.lg.nFurgoniTot;
            dataGridLog.Rows[3].DefaultCellStyle.BackColor = Color.Aqua;
            dataGridLog.Rows[3].Cells[1].Value = genitore.lg.nMotoTot;
            dataGridLog.Rows[4].DefaultCellStyle.BackColor = Color.Red;
            dataGridLog.Rows[5].DefaultCellStyle.BackColor = Color.Lime;
            dataGridLog.Rows[6].DefaultCellStyle.BackColor = Color.Yellow;
            dataGridLog.Rows[7].DefaultCellStyle.BackColor = Color.Aqua;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void dataGridLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
