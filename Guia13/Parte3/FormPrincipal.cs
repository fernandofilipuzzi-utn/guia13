using Parte3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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

        private void btnAtender_Click(object sender, EventArgs e)
        {
            FormDespacho formDespacho = new FormDespacho();

            while (formDespacho.ShowDialog() == DialogResult.OK)
            {
                int id = Convert.ToInt32(formDespacho.tbIdentificador.Text);

                int idx = c.BuscarCorrespondencia(id);
                if (idx == -1) //significa que no lo encontró
                {
                    int cp = Convert.ToInt32(formDespacho.tbCodigoPostal.Text);
                    double peso = Convert.ToDouble(formDespacho.tbPesoEnGramos.Text);
                    int empresa = Convert.ToInt32(formDespacho.cbEmpresa.Text);
                    bool esCertificada = formDespacho.chkTipoEnvio.Checked;

                    double costoBase = 0d;
                    double costoIVA = 0d;
                    double costoTotal = 0d;
                    c.Despachar(id, cp, peso, empresa, esCertificada, ref costoBase, ref costoIVA, ref costoTotal);

                    MessageBox.Show($"BASE: ${costoBase:f2} IVA:${costoIVA:f2} Total:${costoTotal:f2}", "Monto a pagar");

                    #region clear
                    formDespacho.tbIdentificador.Clear();
                    formDespacho.tbCodigoPostal.Clear();
                    formDespacho.tbPesoEnGramos.Clear();
                    formDespacho.cbEmpresa.SelectedIndex = -1;
                    formDespacho.chkTipoEnvio.Checked = false;
                    #endregion
                }
                else
                {
                    MessageBox.Show("Error! - El registro fue previamente cargado");
                }
            }
        }

        private void btnVerResultadosPorLote_Click(object sender, EventArgs e)
        {
            FormVerResultados fVer = new FormVerResultados();

            int empresa = Convert.ToInt32( tbEmpresaResumen.Text);

            int cp;
            double peso;
            c.CorrespondenciaConMayorCostoPorEmpresa(empresa, out cp, out peso);
            int cantidadCartas = c.CantidadDeCorrespondenciaPorEmpesa(empresa);
            double montoRecaudado = c.RecaudacionPorEmpresa(empresa);

            fVer.lbResultados.Items.Add($"Resultados:");

            fVer.lbResultados.Items.Add($"1-  La cantidad de correspondencia recibida: {cantidadCartas}");
            if(cp>0) fVer.lbResultados.Items.Add($"2-  La carta de mayor costo: CP:{cp} Peso:{peso:f2}gr");
            else fVer.lbResultados.Items.Add($"2-  No hubo cartas recepcionadas");
            fVer.lbResultados.Items.Add($"3-  Recaudación: ${montoRecaudado}");

            fVer.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVerResultados fVer = new FormVerResultados();

            int empresa = Convert.ToInt32(tbEmpresaResumen.Text);

            int cantidad = 0;
            int[] idxs = c.PrepararDistribucionAEmpresa(empresa, ref cantidad);

            for (int n = 0; n < cantidad; n++)
            {
                int idx = idxs[n];
                fVer.lbResultados.Items.Add($"{c.CodigosPostales[idx]} - {c.PesosGr[idx]:f2}");
            }

            fVer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDespacho formDespacho = new FormDespacho();

            int id = Convert.ToInt32(tbIdentificador.Text);

            int idx = c.BuscarCorrespondencia(id);
            if (idx > -1)
            {
                formDespacho.tbIdentificador.Text = c.Indentificadores[idx].ToString("00000000");
                formDespacho.tbCodigoPostal.Text = c.CodigosPostales[idx].ToString("0000");
                formDespacho.tbPesoEnGramos.Text = c.PesosGr[idx].ToString("0.00");
                formDespacho.cbEmpresa.Text = c.EmpresasDistribuccion[idx].ToString();
                formDespacho.chkTipoEnvio.Checked = c.SonCertificadas[idx];

                formDespacho.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Registro no encontrado");
            }
        }

        private void btnVerResumenFinal_Click(object sender, EventArgs e)
        {
            FormVerResultados fVer = new FormVerResultados();

            double total = c.RecaudacionTotal();
            double transporte = c.TransporteConMayorCorrespondencia();

            fVer.lbResultados.Items.Add($"Recaudación total: ${total}");
            fVer.lbResultados.Items.Add($"Transporte con mayor correspondencia a entregar: ${transporte}");

            fVer.ShowDialog();
        }
    }
}
