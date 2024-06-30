﻿using Parte2.Models;
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

namespace Parte2
{
    public partial class FormPrincipal : Form
    {
        Controlador c = new Controlador();

        public FormPrincipal()
        {
            InitializeComponent();
            //test
            double costoBase = 0d;
            double costoIVA = 0d;
            double costoTotal = 0d;
            c.Despachar(3137, 126, 1, true,  ref costoBase, ref costoIVA, ref costoTotal);
            c.Despachar(3100, 25, 3, true, ref costoBase, ref costoIVA, ref costoTotal);
            c.Despachar(3100, 125, 2, true, ref costoBase, ref costoIVA, ref costoTotal);
            c.Despachar(3137, 123.1, 2, true, ref costoBase, ref costoIVA, ref costoTotal);
            c.Despachar(3567, 45.7, 1, true, ref costoBase, ref costoIVA, ref costoTotal);
            c.Despachar(4564, 12.5, 1, true, ref costoBase, ref costoIVA, ref costoTotal);
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            FormDespacho formDespacho = new FormDespacho();

            while (formDespacho.ShowDialog() == DialogResult.OK)
            {
                int cp = Convert.ToInt32(formDespacho.tbCodigoPostal.Text);
                double peso=Convert.ToDouble( formDespacho.tbPesoEnGramos.Text);
                int empresa=Convert.ToInt32( formDespacho.cbEmpresa.Text);
                bool esCertificada = formDespacho.chkTipoEnvio.Checked;

                double costoBase = 0d;
                double costoIVA = 0d;
                double costoTotal = 0d;
                c.Despachar(cp, peso, empresa, esCertificada, ref costoBase, ref costoIVA, ref costoTotal);

                MessageBox.Show($"BASE: ${costoBase:f2} IVA:${costoIVA:f2} Total:${costoTotal:f2}", "Monto a pagar");

                #region clear
                formDespacho.tbCodigoPostal.Clear();
                formDespacho.tbPesoEnGramos.Clear();
                formDespacho.cbEmpresa.SelectedIndex = -1;
                formDespacho.chkTipoEnvio.Checked=false;
                #endregion
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

            fVer.lbResultados.Items.Add($"CP - Peso - Certificada");
            for (int n = 0; n < cantidad; n++)
            {
                int idx = idxs[n];

                string esCertificada = "No";
                if (c.SonCertificadas[idx])
                    esCertificada = "Sí";

                fVer.lbResultados.Items.Add($"{c.CodigosPostales[idx]} - {c.PesosGr[idx]:f2} - {esCertificada}");
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
    }
}
