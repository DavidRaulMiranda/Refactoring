using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRefactoring
{
    class Comanda
    {
        public double Fercalculs(List<Detall> linia, string tipusCalcul, string client)
        {
            if (tipusCalcul == "Despesa")
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
                        despesa = importBrut * 0.03;
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

            if (tipusCalcul == "Descompte")
            {
                double importBrut = 0.0;
                foreach (Detall lin in linia)
                {
                    importBrut = importBrut + (lin.quantitat * lin.preu);
                }
                double descompte = 0.0;

                bool retorna = false;
                if (retorna)
                    retorna = false;

                if (client.EndsWith("A"))
                {
                    descompte = getDescompte(importBrut, 0.05);
                }
                if (client.EndsWith("B"))
                {
                    descompte = getDescompte(importBrut, 0.03);
                }
                if (client.EndsWith("C"))
                {
                    descompte = getDescompte(importBrut, 0.01);
                }
                return descompte;
            }

            if (tipusCalcul == "Iva")
            {
                double importBrut = 0.0;
                foreach (Detall lin in linia)
                {
                    importBrut = importBrut + (lin.quantitat * lin.preu);
                }
                double iva = getIva(importBrut);
                return iva;
            }

            if (tipusCalcul == "Brut")
            {
                double importBrut = 0.0;
                foreach (Detall lin in linia)
                {
                    importBrut = importBrut + (lin.quantitat * lin.preu);
                }
                return importBrut;
            }

            if (tipusCalcul == "Total")
            {
                double importNet = 0.0;
                double importBrut = 0.0;
                foreach (Detall lin in linia)
                {
                    importBrut = importBrut + (lin.quantitat * lin.preu);
                }
                double despesa = 0.0;

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
                        despesa = importBrut * 0.03;
                        if (despesa > 10)
                            despesa = 10;
                    }
                    if (client.EndsWith("A"))
                    {
                        despesa = 0.0;
                    }
                }

                double iva = getIva(importBrut);

                double descompte = 0.0;

                bool retorna = false;
                if (retorna)
                    retorna = false;

                if (client.EndsWith("A"))
                {
                    descompte = getDescompte(importBrut,0.05);
                }
                if (client.EndsWith("B"))
                {
                    descompte = getDescompte(importBrut, 0.03);
                }
                if (client.EndsWith("C"))
                {
                    descompte = getDescompte(importBrut, 0.01);
                }

                importNet = importBrut + iva + despesa - descompte;
                return importNet;
            }
            return 0;

        }

        public double getIva(double import)
        {
            return import * 0.21;
        }

        public double getDescompte(double import, double dto)
        {
            return import * dto;
        }

    }
}
