﻿using System;
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

        public Despacho Despachar(int codigoPostal, double peso, int empresaDistribucion,
                                bool EsCertificada)
        {
            Despacho nuevo = new Despacho(codigoPostal, peso, 
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

        public Despacho CartaMayorCostoPorEmpesa(int nroEmpresa)
        {
            Despacho mayor = null;
                       
            for (int n = 0; n < Contador; n++)
            {
                int m = 0;
                if (Despachos[n].Empresa == nroEmpresa)
                {
                    if (m == 0 || mayor.Pago < Despachos[n].Pago)
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
                if (Despachos[n].EmpresaDistribuccion == nroEmpresa)
                    recaudacion += Despachos[n].Pago; 
            }
            return recaudacion;
        }

        public int CorrespondenciaPorEmpesa(int nroEmpresa)
        {
            int cartas = 0;
            for (int n = 0; n < Contador; n++)
            {
                if (Despachos[n].EmpresaDistribuccion == nroEmpresa)
                    cartas++;
            }
            return cartas;
        }

        public double RecaudacionTotal()
        {
            double recaudacion = 0;
            for (int n = 0; n < Contador; n++)
            {
                recaudacion += Despachos[n].Pago;
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


    }
}