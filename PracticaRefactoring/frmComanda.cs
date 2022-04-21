using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PracticaRefactoring
{
    public partial class frmComanda : Form
    {

        List<Detall> Cistella = new List<Detall>();
        Comanda comanda = new Comanda();
        bool podemFinalitzar = false;
        string numComanda;
        string[] DadesComanda;
        int contador = 0;
        public string representant;
        public string zona;
        bool novaComanda = false;


        public frmComanda()
        {
            InitializeComponent();
        }


        private void btnDetall_Click(object sender, EventArgs e)
        {
            

            Detall compra = new Detall();
            compra.Producte = cmbProductes.Text;
            compra.preu = double.Parse(txtPreu.Text);
            compra.quantitat = int.Parse(txtQuantitat.Text);
            Cistella.Add(compra);

            dtgProductes.DataSource = null;
            dtgProductes.DataSource = Cistella;

            txtPreu.Text = "";
            txtQuantitat.Text = "";
        }

       

        private void btnBrut_Click(object sender, EventArgs e)
        {
            double importBrut = 0.0;
            importBrut = comanda.Fercalculs(Cistella, "Brut", cmbClients.Text);
            importBrut = Math.Round(importBrut, 2, MidpointRounding.AwayFromZero);
            lblBrut.Text = importBrut.ToString();
            DadesComanda[2] = importBrut.ToString();
        }

        private void btnIVA_Click(object sender, EventArgs e)
        {
            double iva = 0.0;
            iva = comanda.Fercalculs(Cistella, "Iva",  cmbClients.Text);
            iva = Math.Round(iva, 2, MidpointRounding.AwayFromZero);
            lblIva.Text = iva.ToString();
            DadesComanda[3] = iva.ToString();
        }

        private void btnDespesa_Click(object sender, EventArgs e)
        {
            double despesa=0.0;
            despesa = comanda.Fercalculs(Cistella, "Despesa", cmbClients.Text);
            despesa = Math.Round(despesa, 2, MidpointRounding.AwayFromZero);
            lblDespesa.Text = despesa.ToString();
            DadesComanda[4] = despesa.ToString();
        }


        private void btnDescompte_Click(object sender, EventArgs e)
        {
            double descompte = 0.0;
            descompte = comanda.Fercalculs(Cistella, "Descompte", cmbClients.Text);
            descompte = Math.Round(descompte, 2, MidpointRounding.AwayFromZero);
            lbldescompte.Text = descompte.ToString();
            DadesComanda[5] = descompte.ToString();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double importNet = 0.0;
            importNet = comanda.Fercalculs(Cistella, "Total", cmbClients.Text);
            importNet = Math.Round(importNet, 2, MidpointRounding.AwayFromZero);
            lblTotal.Text = importNet.ToString();
            podemFinalitzar = true;
            grpResum.Visible = true;
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            novaComanda = true;
            contador = contador  + 1;
            DadesComanda = new string[7];
            int dia = DateTime.Today.DayOfYear;
            numComanda = dia.ToString() + "-" + contador.ToString();
            lblComanda.Text = numComanda;
            DadesComanda[0] = numComanda;
            DadesComanda[1] = cmbClients.Text;
        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(novaComanda)
                DadesComanda[1] = cmbClients.Text;
        }

        private void cmbEstat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstat.SelectedIndex == 0) 
                EstatEnEspera();
            if (cmbEstat.SelectedIndex == 1)
                EstatRetingut();
            if (cmbEstat.SelectedIndex == 2)
                EstatCondicionat();
            if (cmbEstat.SelectedIndex == 3)
                EstatConfirmat();
        }

        private void EstatEnEspera()
        {
            DadesComanda[6] = "En espera";
        }
        private void EstatRetingut()
        {
            DadesComanda[6] = "Retinguda";
        }
        private void EstatCondicionat()
        {
            DadesComanda[6] = "Condicionada";
        }
        private void EstatConfirmat()
        {
            DadesComanda[6] = "Confirmada";
        }

        private void btnResum_Click(object sender, EventArgs e)
        {
            frmResum frm = new frmResum();
            frm.zona = zona;
            frm.detall = Cistella;
            frm.dades = DadesComanda;
            frm.Show();
            

        }

        private void frmComanda_Load(object sender, EventArgs e)
        {
            lblRepresentant.Text = representant;
        }
    }
}
