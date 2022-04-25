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
            double despesa;
            double descompte;
            double importBrut;

            if (tipusCalcul == "Despesa")
            {
                despesa = getDespesa(linia, client);
                return despesa;
            }

            if (tipusCalcul == "Descompte")
            {
                descompte = getDescompte(linia, client);
                return descompte;
            }

            if (tipusCalcul == "Iva")
            {
                importBrut = getImportBrut(linia);
                double iva = getIva(importBrut);
                return iva;
            }

            if (tipusCalcul == "Brut")
            {
                importBrut = getImportBrut(linia);
                return importBrut;
            }

            if (tipusCalcul == "Total")
            {
                double importNet = 0.0;
                importBrut = getImportBrut(linia);
                despesa = 0.0;

                despesa = getDespesa(client, despesa, importBrut);

                double iva = getIva(importBrut);

                descompte = 0.0;

                bool retorna = false;
                if (retorna)
                    retorna = false;

                descompte = getDescompte(importBrut, client);

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

        public double getDescompte(double import, double dto)
        {
            return import * dto;
        }

        public double getDescompte(double importBrut, string client)
        {
            double descompte = 0.0;

            if (client.EndsWith("A"))
            {
                descompte = importBrut * cincPerCent;
            }else if (client.EndsWith("B"))
            {
                descompte = importBrut * tresPerCent;
            }else if (client.EndsWith("C"))
            {
                descompte = importBrut * uPerCent;
            }

            return descompte;
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

        public double getDescompte(List<Detall> linia, string client)
        {
            double importBrut = 0.0;
            foreach (Detall lin in linia)
            {
                importBrut = importBrut + (lin.quantitat * lin.preu);
            }

            bool retorna = false;
            if (retorna) retorna = false;

            return getDescompte(importBrut, client);
        }
    }
}
