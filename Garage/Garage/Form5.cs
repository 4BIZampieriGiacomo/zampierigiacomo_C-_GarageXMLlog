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
            dataGridLog.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128);
            dataGridLog.Rows[0].Cells[1].Value = genitore.lg.nVeicoliTot;
            dataGridLog.Rows[1].DefaultCellStyle.BackColor = Color.FromArgb(128, 255, 128);
            dataGridLog.Rows[1].Cells[1].Value = genitore.lg.nAutoTot;
            dataGridLog.Rows[2].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 128);
            dataGridLog.Rows[2].Cells[1].Value = genitore.lg.nFurgoniTot;
            dataGridLog.Rows[3].DefaultCellStyle.BackColor = Color.FromArgb(128, 255, 255);
            dataGridLog.Rows[3].Cells[1].Value = genitore.lg.nMotoTot;
            dataGridLog.Rows[4].DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128);
            dataGridLog.Rows[4].Cells[1].Value = genitore.lg.tVeicoloMedio;
            dataGridLog.Rows[5].DefaultCellStyle.BackColor = Color.FromArgb(128, 255, 128);
            dataGridLog.Rows[5].Cells[1].Value = genitore.lg.tAutoMedio;
            dataGridLog.Rows[6].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 128);
            dataGridLog.Rows[6].Cells[1].Value = genitore.lg.tFurgoniMedio;
            dataGridLog.Rows[7].DefaultCellStyle.BackColor = Color.FromArgb(128, 255, 255);
            dataGridLog.Rows[7].Cells[1].Value = genitore.lg.tMotoMedio;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void dataGridLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void DisegnaGraficoATorta1()
        {
            float total = genitore.lg.nAutoEl + genitore.lg.nAutoNEl;
            float d1 = (genitore.lg.nAutoEl / total) * 360;
            float d2 = (genitore.lg.nAutoNEl / total) * 360;

            Pen p = new Pen(Color.Black, 1);
            Graphics g = pictureBox1.CreateGraphics();
            Rectangle rect = new Rectangle(10, 10, 200, 200);

            Brush brush1 = new SolidBrush(Color.Green);
            Brush brush2 = new SolidBrush(Color.Red);
            g.Clear(pictureBox1.BackColor);

            g.DrawPie(p, rect, 0, d1);
            g.FillPie(brush1, rect, 0, d1);
            g.DrawPie(p, rect, d1, d2);
            g.FillPie(brush2, rect, d1, d2);
        }

        public void DisegnaGraficoATorta2()
        {
            float total = genitore.lg.nAutoTot + genitore.lg.nFurgoniTot + genitore.lg.nMotoTot;
            float d1 = (genitore.lg.nAutoTot / total) * 360;
            float d2 = (genitore.lg.nFurgoniTot / total) * 360;
            float d3 = (genitore.lg.nMotoTot / total) * 360;

            Pen p = new Pen(Color.Black, 1);
            Graphics g = pictureBox2.CreateGraphics();
            Rectangle rect = new Rectangle(10, 10, 200, 200);

            Brush brush1 = new SolidBrush(Color.Green);
            Brush brush2 = new SolidBrush(Color.Red);
            Brush brush3 = new SolidBrush(Color.Blue);
            g.Clear(pictureBox2.BackColor);

            g.DrawPie(p, rect, 0, d1);
            g.FillPie(brush1, rect, 0, d1);
            g.DrawPie(p, rect, d1, d2);
            g.FillPie(brush2, rect, d1, d2);
            g.DrawPie(p, rect, d1 + d2, d3);
            g.FillPie(brush3, rect, d1 + d2, d3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisegnaGraficoATorta1();
            DisegnaGraficoATorta2();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
