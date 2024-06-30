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

            //test
            c.Despachar(234, 3137, 126, 1, true);
            c.Despachar(235, 3100, 25, 3, true);
            c.Despachar(237, 3100, 125, 2, true);
            c.Despachar(239, 3137, 123.1, 2, true);
            c.Despachar(244, 3567, 45.7, 1, true);
            c.Despachar(245, 4564, 12.5, 1, true);
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            FormDespacho formDespacho = new FormDespacho();

            while (formDespacho.ShowDialog() == DialogResult.OK)
            {
                int id = Convert.ToInt32(formDespacho.tbIdentificador.Text);
                int cp = Convert.ToInt32(formDespacho.tbCodigoPostal.Text);
                double peso = Convert.ToDouble(formDespacho.tbPesoEnGramos.Text);
                int empresa = Convert.ToInt32(formDespacho.cbEmpresa.Text);
                bool esCertificada = formDespacho.chkTipoEnvio.Checked;

                Despacho nuevo = c.Despachar(id,cp, peso, empresa, esCertificada);

                MessageBox.Show($"BASE: ${nuevo.CostoBase:f2} IVA:${nuevo.IVA:f2} Total:${nuevo.CostoAPagar:f2}", "Monto a pagar");

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

            fVer.lbResultados.Items.Add($"CP - Peso - Certificada");
            for (int n = 0; n < cantidad; n++)
            {
                string esCertificada = "No";
                if (ds[n].EsCertificada)
                    esCertificada = "Sí";

                fVer.lbResultados.Items.Add($"{ds[n].CodigoPostal} - {ds[n].CostoAPagar:f2} - {esCertificada}");
            }

            fVer.ShowDialog();
        }

        private void btnVerResumenFinal_Click(object sender, EventArgs e)
        {
            FormVerResultados fVer = new FormVerResultados();

            double total = c.RecaudacionTotal();
            double transporte = c.TransporteConMayorCorrespondencia();

            fVer.lbResultados.Items.Add($"Recaudación total: ${total}");
            fVer.lbResultados.Items.Add($"Transporte con mayor correspondencia a entregar: {transporte}");

            fVer.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormDespacho formDespacho = new FormDespacho();

            int id = Convert.ToInt32(tbIdentificador.Text);

            int idx = c.BuscarDespacho(id);
            if (idx > -1)
            {
                Despacho carta = c.VerDespacho(idx);

                formDespacho.tbIdentificador.Text = carta.Identificador.ToString("00000000");
                formDespacho.tbCodigoPostal.Text = carta.CodigoPostal.ToString("0000");
                formDespacho.tbPesoEnGramos.Text = carta.PesoGr.ToString("0.00");
                formDespacho.cbEmpresa.Text = carta.Empresa.ToString();
                formDespacho.chkTipoEnvio.Checked = carta.EsCertificada;

                formDespacho.tbIdentificador.Enabled = false;
                formDespacho.tbCodigoPostal.Enabled = false;
                formDespacho.tbPesoEnGramos.Enabled = false;
                formDespacho.cbEmpresa.Enabled = false;
                formDespacho.chkTipoEnvio.Enabled = false;

                formDespacho.ShowDialog();
            }
            else
            {
                MessageBox.Show("Registro no encontrado");
            }
        }
    }
}