using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRefactoring
{
    class Comanda
    {
        readonly double iva = 0.21;
        readonly double cincPerCent = 0.05;
        readonly double tresPerCent = 0.03;
        readonly double uPerCent = 0.01;

        public double Fercalculs(List<Detall> linia, string tipusCalcul, string client)
        {
            double despesa = 0.0;
            double descompte;
            double importBrut;
            double iva;
            double importNet;

            if (tipusCalcul == "Despesa")
            {
                despesa = getDespesa(linia, client);
                return despesa;
            }

            if (tipusCalcul == "Descompte")
            {
                importBrut = calcularBruto(linia, client);
                descompte = getDescompteClient(importBrut, client);
                return descompte;
            }

            if (tipusCalcul == "Iva")
            {
                importBrut = getImportBrut(linia);
                iva = getIva(importBrut);
                return iva;
            }

            if (tipusCalcul == "Brut")
            {
                importBrut = getImportBrut(linia);
                return importBrut;
            }

            if (tipusCalcul == "Total")
            {
                importBrut = getImportBrut(linia);

                despesa = getDespesa(client, despesa, importBrut);

                iva = getIva(importBrut);

                descompte = getDescompteClient(importBrut, client);

                importNet = importBrut + iva + despesa - descompte;
                return importNet;
            }
            return 0;

        }

        private double getDespesa(string client, double despesa, double importBrut)
        {
            if (client.EndsWith("B"))
            {
                if (importBrut > 500)
                {
                    despesa = 0.0;
                }
                else
                {
                    despesa = 5.0;
                }
            }
            else
            {
                if (client.EndsWith("C"))
                {
                    despesa = importBrut * tresPerCent;
                    if (despesa > 10)
                        despesa = 10;
                }
                if (client.EndsWith("A"))
                {
                    despesa = 0.0;
                }
            }

            return despesa;
        }

        private double getImportBrut(List<Detall> linia)
        {
            double importBrut = 0.0;
            foreach (Detall lin in linia)
            {
                importBrut = importBrut + (lin.quantitat * lin.preu);
            }

            return importBrut;
        }

        public double getIva(double import)
        {
            return import * iva;
        }

        public double getDespesa(List<Detall> linia, string client)
        {

            double despesa = 0.0;
            double importBrut = 0.0;
            foreach (Detall lin in linia)
            {
                importBrut = importBrut + (lin.quantitat * lin.preu);
            }

            if (client.EndsWith("B"))
            {
                if (importBrut > 500)
                {
                    despesa = 0.0;
                }
                else
                {
                    despesa = 5.0;
                }
            }
            else
            {
                if (client.EndsWith("C"))
                {
                    despesa = importBrut * tresPerCent;
                    if (despesa > 10)
                        despesa = 10;
                }
                if (client.EndsWith("A"))
                {
                    despesa = 0.0;
                }
            }
            return despesa;
        }

        public double calcularBruto(List<Detall> linia, string client)
        {
            double importBrut = 0.0;

            foreach (Detall lin in linia)
            {
                importBrut = importBrut + (lin.quantitat * lin.preu);
            }

            return importBrut;
        }

        public double getDescompteClient(double importBrut, string client)
        {
            double descompte = 0.0;

            if (client.EndsWith("A"))
            {
                descompte = importBrut * cincPerCent;
            }
            else if (client.EndsWith("B"))
            {
                descompte = importBrut * tresPerCent;
            }
            else if (client.EndsWith("C"))
            {
                descompte = importBrut * uPerCent;
            }

            return descompte;
        }

    }
}
