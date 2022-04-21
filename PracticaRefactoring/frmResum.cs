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
        public frmResum()
        {
            InitializeComponent();
        }

        public string[] dades = new string[7];
        public List<Detall> detall;
        public string zona;


        private void frmResum_Load(object sender, EventArgs e)
        {
            if (zona=="Insular")
            {
                lblObservacions.Text = "Observacions: Pendent de confiormació des de la central";
            }

            lblBrut.Text = dades[2];
            lblIva.Text = dades[3];
            lblDespesa.Text = dades[4];
            lbldescompte.Text = dades[5];

            lblComanda.Text = dades[0];
            lblClient.Text = dades[1];
            lblestat.Text = dades[6];
            double total = 0.0;

            total = double.Parse(lblBrut.Text) + double.Parse(lblIva.Text)
                    + double.Parse(lblDespesa.Text) - double.Parse(lbldescompte.Text);
            lblTotal.Text = total.ToString();

            dtgProductes.DataSource = detall;
        }
    }
}
