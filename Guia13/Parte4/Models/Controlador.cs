using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Parte4.Models
{
    public class Controlador
    {

        private Despacho[] Despachos = new Despacho[1000];
        public int Contador { get; private set; } = 0;


        public Despacho VerDespacho(int idx)
        {
            if(idx<Contador)
                return Despachos[idx];
            return null;
        }

        public Despacho Despachar(int identificador, int codigoPostal, double peso, int empresaDistribucion,
                                bool EsCertificada)
        {
            Despacho nuevo = new Despacho(identificador, codigoPostal, peso, 
                                          empresaDistribucion, EsCertificada);

            Despachos[Contador] = nuevo;
            Contador++;

            return nuevo;
        }

        public int CantidadDeCorrespondenciaPorEmpesa(int nroEmpresa)
        {
            int cantidad = 0;
            for (int n = 0; n < Contador; n++)
            {
                if (Despachos[n].Empresa == nroEmpresa)
                    cantidad++;
            }
            return cantidad;
        }

        public Despacho CorrespondenciaConMayorCostoPorEmpresa(int nroEmpresa)
        {
            Despacho mayor = null;
                       
            for (int n = 0; n < Contador; n++)
            {
                int m = 0;
                if (Despachos[n].Empresa == nroEmpresa)
                {
                    if (m == 0 || mayor.CostoAPagar < Despachos[n].CostoAPagar )
                    {
                        mayor = Despachos[n];
                        m++;
                    }
                }
            }

            return mayor;
        }

        public double RecaudacionPorEmpesa(int nroEmpresa)
        {
            double recaudacion = 0;
            for (int n = 0; n < Contador; n++)
            {
                if (Despachos[n].Empresa == nroEmpresa)
                    recaudacion += Despachos[n].CostoAPagar; 
            }
            return recaudacion;
        }

        public int CorrespondenciaPorEmpesa(int nroEmpresa)
        {
            int cartas = 0;
            for (int n = 0; n < Contador; n++)
            {
                if (Despachos[n].Empresa == nroEmpresa)
                    cartas++;
            }
            return cartas;
        }

        public double RecaudacionTotal()
        {
            double recaudacion = 0;
            for (int n = 0; n < Contador; n++)
            {
                recaudacion += Despachos[n].CostoAPagar;
            }
            return recaudacion;
        }

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

        /*
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
        */

        public Despacho[] PrepararDistribucionAEmpresa(int empresa, ref int cantidad)
        {
            cantidad = 0;
            Despacho[] aDistribuir = new Despacho[1000];

            for (int n = 0; n < Contador; n++)
            {
                if (Despachos[n].Empresa == empresa)
                {
                    aDistribuir[cantidad] = Despachos[n];
                    cantidad++;
                }
            }

            Ordenar(aDistribuir, cantidad);

            return aDistribuir;
        }

        private void Ordenar(Despacho[] aDistribuir, int cantidad)
        {
            for (int n = 0; n < cantidad - 1; n++)
            {
                for (int m = n + 1; m < cantidad; m++)
                {
                    if (aDistribuir[n].CodigoPostal > aDistribuir[m].CodigoPostal)
                    {
                        Despacho aux = aDistribuir[n];
                        aDistribuir[n] = aDistribuir[m];
                        aDistribuir[m] = aux;
                    }
                }
            }
        }

        public int BuscarDespacho(int identificador)
        {
            int idx = -1;
            int n = 0;
            while (n < Contador && idx == -1)
            {
                if (Despachos[n].Identificador == identificador)
                    idx = n;
                n++;
            }
            return idx;
        }
    }
}
