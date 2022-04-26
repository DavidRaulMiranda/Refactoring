using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PracticaRefactoring
{
    public partial class frmComanda : Form
    {
        DadesComanda dadesComanda;
        List<Detall> Cistella = new List<Detall>();
        Comanda comanda = new Comanda();
        string numComanda;
        int contador = 0;
        public string representant;
        public string zona;
        bool novaComanda = false;


        public frmComanda(string _representant, string _zona)
        {  
          representant = _representant;
          zona= _zona;  
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
            double importBrut;
            importBrut = comanda.Fercalculs(Cistella, "Brut", cmbClients.Text);
            importBrut = Math.Round(importBrut, 2, MidpointRounding.AwayFromZero);
            lblBrut.Text = importBrut.ToString();
            dadesComanda.Brut = importBrut;
        }

        private void btnIVA_Click(object sender, EventArgs e)
        {
            double iva;
            iva = comanda.Fercalculs(Cistella, "Iva",  cmbClients.Text);
            iva = Math.Round(iva, 2, MidpointRounding.AwayFromZero);
            lblIva.Text = iva.ToString();
            dadesComanda.Iva = iva;
        }

        private void btnDespesa_Click(object sender, EventArgs e)
        {
            double despesa;
            despesa = comanda.Fercalculs(Cistella, "Despesa", cmbClients.Text);
            despesa = Math.Round(despesa, 2, MidpointRounding.AwayFromZero);
            lblDespesa.Text = despesa.ToString();
            dadesComanda.Despesa = despesa;
        }


        private void btnDescompte_Click(object sender, EventArgs e)
        {
            double descompte;
            descompte = comanda.Fercalculs(Cistella, "Descompte", cmbClients.Text);
            descompte = Math.Round(descompte, 2, MidpointRounding.AwayFromZero);
            lbldescompte.Text = descompte.ToString();
            dadesComanda.Descompte = descompte;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double importNet;
            importNet = comanda.Fercalculs(Cistella, "Total", cmbClients.Text);
            importNet = Math.Round(importNet, 2, MidpointRounding.AwayFromZero);
            lblTotal.Text = importNet.ToString();
            grpResum.Visible = true;
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            novaComanda = true;
            contador = contador  + 1;
            dadesComanda = new DadesComanda();
            int dia = DateTime.Today.DayOfYear;
            numComanda = dia.ToString() + "-" + contador.ToString();
            lblComanda.Text = numComanda;
            dadesComanda.Comanda = numComanda;
            dadesComanda.Client = cmbClients.Text;
        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(novaComanda)
                dadesComanda.Client = cmbClients.Text;
        }

        private void cmbEstat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstat.SelectedIndex == 0)
            {
                dadesComanda.Estat = "En espera";
            }
            else if (cmbEstat.SelectedIndex == 1)
            {
                dadesComanda.Estat = "Retinguda";
            }else if (cmbEstat.SelectedIndex == 2)
            {
                dadesComanda.Estat = "Condicionada";
            }
            else if (cmbEstat.SelectedIndex == 3)
            {
                dadesComanda.Estat = "Confirmada";
            }
        }

        private void btnResum_Click(object sender, EventArgs e)
        {
            frmResum frm = new frmResum(dadesComanda, Cistella, zona);
            frm.Show();
   
        }

        private void frmComanda_Load(object sender, EventArgs e)
        {
            lblRepresentant.Text = representant;
        }
    }
}
