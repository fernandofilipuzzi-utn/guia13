using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Parte2.Models
{
    public class Controlador
    {
        public int[] CodigosPostales = new int[1000];
        public double[] PesosGr = new double[1000];
        public int[] EmpresasDistribuccion = new int[1000];
        public double[] Pagos = new double[1000];
        public bool[] SonCertificadas = new bool[1000];
        public int Contador = 0;

        public void Despachar(int codigoPostal, double peso, int empresaDistribucion, bool EsCertificada, ref double CostoBase, ref double IVA, ref double CostoAPagar)
        {
            CodigosPostales[Contador] = codigoPostal;
            PesosGr[Contador] = peso;
            EmpresasDistribuccion[Contador] = empresaDistribucion;
            SonCertificadas[Contador] = EsCertificada;

            #region calculo del los costos
            double Tarifa = 0.5;
            if (EsCertificada)
            {
                Tarifa = 1;
            }
            CostoBase = peso * Tarifa;
            IVA = CostoBase * 21d / 100;
            CostoAPagar = CostoBase + IVA;

            Pagos[Contador] = CostoAPagar;
            Contador++;
            #endregion
        }
             
        public int CantidadDeCorrespondenciaPorEmpesa(int nroEmpresa)
        {
            int cantidad = 0;
            for (int n = 0; n < Contador; n++)
            {
                if (EmpresasDistribuccion[n] == nroEmpresa)
                    cantidad++;
            }
            return cantidad;
        }
        public double RecaudacionPorEmpresa(int nroEmpresa)
        {
            double recaudacion = 0;
            for (int n = 0; n < Contador; n++)
            {
                if (EmpresasDistribuccion[n] == nroEmpresa)
                    recaudacion += Pagos[n];
            }
            return recaudacion;
        }
        public void CorrespondenciaConMayorCostoPorEmpresa( int nroEmpresa, out int cp, out double peso)
        {
            cp = -1;
            peso = 0;

            double costo = 0;
            int m = 0;
            for (int n = 0; n < Contador; n++)
            {
                if (EmpresasDistribuccion[n] == nroEmpresa)
                {
                    if (m == 0 && Pagos[n] > costo)
                    {
                        cp = CodigosPostales[n];
                        peso = PesosGr[n];
                        m++;
                    }
                }
            }
        }

        public double RecaudacionTotal()
        {
            double recaudacion = 0;
            for (int n = 0; n < Contador; n++)
            {
                recaudacion += Pagos[n];
            }
            return recaudacion;
        }
              
        /*
        public int TransporteConMayorCorrespondencia()
        {
            int nroTMayor = -1;
            int cantMayor = 0;

            for (int empresa = 1; empresa < 3; empresa++)
            {
                int cantCorrespondencia = CorrespondenciaPorEmpesa(empresa);
                if (empresa == 1 || cantMayor < cantCorrespondencia)
                    nroTMayor = empresa;
            }
            return nroTMayor;
        }
        */

        public int TransporteConMayorCorrespondencia()
        {
            int nroTMayor = -1;
        
            int c1=0, c2=0, c3=0;

            for (int cartas = 0; cartas < Contador; cartas++)
            {
                switch (EmpresasDistribuccion[cartas])
                {
                    case 1: 
                        {
                            c1++;
                        }break;
                    case 2:
                        {
                            c2++;
                        }
                        break;
                    case 3:
                        {
                            c3++;
                        }
                        break;
                }
            }

            nroTMayor = 1;
            if (c2 > c1)
            {
                nroTMayor = 2;
            }
            if (c3 > c2)
            {
                nroTMayor = 3;
            }
            return nroTMayor;
        }

        public int[] PrepararDistribucionAEmpresa(int empresa, ref int cantidad)
        {
            cantidad = 0;
            int[] idxs =new int[1000];
                       
            for (int n = 0; n < Contador; n++)
            {
                if (EmpresasDistribuccion[n] == empresa)
                {
                    idxs[cantidad] = n;
                    cantidad++;
                }
            }

            Ordenar(idxs, cantidad);

            return idxs;
        }

        private void Ordenar(int[] idxs, int cantidad)
        {
            for (int n = 0; n < cantidad - 1; n++)
            {
                //int cpn = CodigosPostales[n]; //es un error!
                int ns = idxs[n];//corrección: indice Actual

                for (int m = n + 1; m < cantidad; m++)
                {
                    //int cps = CodigosPostales[m];
                    int ms = idxs[m]; //corrección: indice Siguiente
                    //if (cpn > cps)
                    if(CodigosPostales[ns] > CodigosPostales[ms])
                    {
                        int aux = idxs[n];
                        idxs[n] = idxs[m];
                        idxs[m] = aux;
                    }
                }
            }
        }
    }
}
