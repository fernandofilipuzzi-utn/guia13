using Parte4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte4
{
    public partial class FormPrincipal : Form
    {
        Controlador c = new Controlador();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAtender_Click(object sender, EventArgs e)
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

        private void btnVerResultadosPorLote_Click(object sender, EventArgs e)
        {
            FormVerResultados fVer = new FormVerResultados();

            int empresa = Convert.ToInt32(tbEmpresaResumen.Text);

            #region consultas
            double montoRecaudado = c.RecaudacionTotal();
            Despacho d = c.CorrespondenciaConMayorCostoPorEmpresa(empresa);
            int cantidadCartas = c.CantidadDeCorrespondenciaPorEmpesa(empresa);
            #endregion

            #region inicializa ventana modal
            fVer.lbResultados.Items.Add($"Resultados:");
            fVer.lbResultados.Items.Add($"1-  La cantidad de correspondencia recibida: {cantidadCartas}");
            if (d != null)
            {
                fVer.lbResultados.Items.Add($"2-  La carta de mayor costo: CP:{d.CodigoPostal} Peso:{d.PesoGr:f2}gr");
            }
            else
            {
                fVer.lbResultados.Items.Add($"2-  No hubo cartas recepcionadas");
            }
            fVer.lbResultados.Items.Add($"3-  Recaudación: ${montoRecaudado}");
            #endregion

            fVer.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVerResultados fVer = new FormVerResultados();

            int empresa = Convert.ToInt32(tbEmpresaResumen.Text);

            int cantidad = 0;
            Despacho[] ds = c.PrepararDistribucionAEmpresa(empresa, ref cantidad);

            for (int n = 0; n < cantidad; n++)
            {
                fVer.lbResultados.Items.Add($"{ds[n].CodigoPostal} - {ds[n].PesoGr:f2}");
            }

            fVer.ShowDialog();
        }
    }
}