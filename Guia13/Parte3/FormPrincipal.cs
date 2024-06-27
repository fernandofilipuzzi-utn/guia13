using Parte3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte3
{
    public partial class FormPrincipal : Form
    {
        Controlador c = new Controlador();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAtención_Click(object sender, EventArgs e)
        {
            FormDespacho formDespacho = new FormDespacho();

            while (formDespacho.ShowDialog() == DialogResult.OK)
            {
                int cp = Convert.ToInt32(formDespacho.tbCodigoPostal.Text);
                double peso = Convert.ToDouble(formDespacho.tbPesoEnGramos.Text);
                int empresa = Convert.ToInt32(formDespacho.cbEmpresa.Text);
                bool esCertificada = formDespacho.chkTipoEnvio.Checked;

                Despacho nuevo = c.Despachar(cp, peso, empresa, esCertificada);

                MessageBox.Show($"BASE: ${nuevo.CostoBase:f2} IVA:${nuevo.IVA:f2} Total:${nuevo.Pago:f2}", "Monto a pagar");

                #region clear
                formDespacho.tbCodigoPostal.Clear();
                formDespacho.tbPesoEnGramos.Clear();
                formDespacho.cbEmpresa.SelectedIndex = -1;
                formDespacho.chkTipoEnvio.Checked = false;
                #endregion
            }


        }

    }
}