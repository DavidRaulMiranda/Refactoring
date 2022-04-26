using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaRefactoring
{
    public partial class frmResum : Form
    {
        DadesComanda dadesComanda;
        List<Detall> detall;
        string zona;
        public frmResum(DadesComanda _dadesComanda, List<Detall> _detall, string _zona)
        {
            dadesComanda = _dadesComanda;
            detall = _detall;
            zona = _zona;
            InitializeComponent();

        }
        private void frmResum_Load(object sender, EventArgs e)
        {

            if (zona == "Insular")
            {
                lblObservacions.Text = "Observacions: Pendent de confiormació des de la central";
            }

            lblComanda.Text = dadesComanda.Comanda;
            lblClient.Text = dadesComanda.Client;
            lblestat.Text = dadesComanda.Estat;


            lblBrut.Text = dadesComanda.Brut.ToString();
            lblIva.Text = dadesComanda.Iva.ToString();
            lblDespesa.Text = dadesComanda.Despesa.ToString();
            lbldescompte.Text = dadesComanda.Descompte.ToString();

            lblTotal.Text = (dadesComanda.Brut
                + dadesComanda.Iva
                + dadesComanda.Despesa
                - dadesComanda.Descompte).ToString(); ;

            dtgProductes.DataSource = detall;
        }
    }
}