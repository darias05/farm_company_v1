using System;
using System.Collections.Generic;
using System.Text;
using farm_company_v1.DTO;

namespace farm_company_v1.Logic
{
    public class BusinessLogicTheFarmersCompany
    {
        public static void PaymentValueToCapitalists(List<Dto_Crop> Crops, List<Dto_Farmer> Farmers)
        {
            int ventas = 0;
            string name = "";
            double paymentForTheCapitalist = 0;

            for (int i = 0; i < Farmers.Count; i++)
            {
                if (Farmers[i].Capitalist == "True")
                {
                    for (int j = 0; j < Crops.Count; j++)
                    {
                        if (Farmers[i].Document == Crops[j].Farmer.Document && Crops[j].Status == "sold out")
                        {
                            double value = 0;
                            name = Farmers[i].Name;
                            string gender = Farmers[i].Gender;
                            double extension = Crops[j].Extension;
                            int unitPerKilometer = Crops[j].Product.UnitPerKilometer;
                            int unitPrice = Crops[j].Product.UnitPrice;
                            double taxPerUnitPercentage = Crops[j].Product.TaxPerUnitPercentage;
                            double productValue = (unitPerKilometer * extension) * (unitPrice);

                            if (gender == "F")
                            {
                                taxPerUnitPercentage = taxPerUnitPercentage / 2;
                                value = productValue - (productValue * (taxPerUnitPercentage / 100));
                                paymentForTheCapitalist = paymentForTheCapitalist + value;
                            } else {
                                value = productValue - (productValue * (taxPerUnitPercentage / 100));
                                paymentForTheCapitalist = paymentForTheCapitalist + value;
                            }

                            ventas++;
                        }
                    }

                    if (ventas > 1)
                    {
                        Console.WriteLine("El precio a pagar por los " + ventas + " productos vendidos del Capitalista llamado " + name + " es de = " + 
                            paymentForTheCapitalist + " Dolares");
                    } else {
                        Console.WriteLine("El capitalista no vendio mas de un producto, solo realizo " + ventas + "venta.");
                    }
                }
            }
        }

        public static void PaymentValueToFarmers(List<Dto_Crop> Crops)
        {
            int ventas = 0;
            double paymentForTheFarmers = 0;

            for (int j = 0; j < Crops.Count; j++)
            {
                if (Crops[j].Status == "sold out")
                {
                    double value = 0;
                    string gender = Crops[j].Farmer.Gender;
                    double extension = Crops[j].Extension;
                    int unitPerKilometer = Crops[j].Product.UnitPerKilometer;
                    int unitPrice = Crops[j].Product.UnitPrice;
                    double taxPerUnitPercentage = Crops[j].Product.TaxPerUnitPercentage;
                    double productValue = (unitPerKilometer * extension) * (unitPrice);

                    if (gender == "F")
                    {
                        taxPerUnitPercentage = taxPerUnitPercentage / 2;
                        value = productValue - (productValue * (taxPerUnitPercentage / 100));
                        paymentForTheFarmers = paymentForTheFarmers + value;
                    }
                    else
                    {
                        value = productValue - (productValue * (taxPerUnitPercentage / 100));
                        paymentForTheFarmers = paymentForTheFarmers + value;
                    }

                    ventas++;
                }
            }
            ventas++;

            if (ventas > 0)
            {
                Console.WriteLine("El precio a pagar por todas las " + ventas + " ventas de todos los agricultores es de = " +
                    paymentForTheFarmers + " Dolares");
            }
            else
            {
                Console.WriteLine("Se han realizado un total de " + ventas + "ventas.");
            }
        }

        public static void LowestPriceSell(List<Dto_Crop> Crops)
        {
            double valuesell = 0;
            string farmerName = "";
            string farmerGender = "";
            string productName = "";
            int productUnitPerKilometer = 0;
            int productUnitPrice = 0;
            double cropExtension = 0;
            double productTaxPerUnitPercentage = 0;

            for (int j = 0; j < Crops.Count; j++)
            {
                if (Crops[j].Status == "sold out")
                {
                    double value = 0;
                    string gender = Crops[j].Farmer.Gender;
                    double extension = Crops[j].Extension;
                    int unitPerKilometer = Crops[j].Product.UnitPerKilometer;
                    int unitPrice = Crops[j].Product.UnitPrice;
                    double paymentForTheFarmer = 0;
                    double taxPerUnitPercentage = Crops[j].Product.TaxPerUnitPercentage;
                    double productValue = (unitPerKilometer * extension) * (unitPrice);

                    if (gender == "F")
                    {
                        taxPerUnitPercentage = taxPerUnitPercentage / 2;
                        value = productValue - (productValue * (taxPerUnitPercentage / 100));
                        paymentForTheFarmer = paymentForTheFarmer + value;
                    }
                    else
                    {
                        value = productValue - (productValue * (taxPerUnitPercentage / 100));
                        paymentForTheFarmer = paymentForTheFarmer + value;
                    }

                    if(valuesell == 0)
                    {
                        farmerName = Crops[j].Farmer.Name;
                        farmerGender = Crops[j].Farmer.Gender;
                        productName = Crops[j].Product.Name;
                        productUnitPerKilometer = Crops[j].Product.UnitPerKilometer;
                        productUnitPrice = Crops[j].Product.UnitPrice;
                        cropExtension = Crops[j].Extension;
                        valuesell = paymentForTheFarmer;

                        if (farmerGender == "F")
                        {
                            productTaxPerUnitPercentage = Crops[j].Product.TaxPerUnitPercentage / 2;
                        }
                        else
                        {
                            productTaxPerUnitPercentage = Crops[j].Product.TaxPerUnitPercentage;
                        }
                    } 
                    else if (paymentForTheFarmer < valuesell)
                    {
                        farmerName = Crops[j].Farmer.Name;
                        farmerGender = Crops[j].Farmer.Gender;
                        productName = Crops[j].Product.Name;
                        productUnitPerKilometer = Crops[j].Product.UnitPerKilometer;
                        productUnitPrice = Crops[j].Product.UnitPrice;
                        cropExtension = Crops[j].Extension;
                        valuesell = paymentForTheFarmer;

                        if (farmerGender == "F")
                        {
                            productTaxPerUnitPercentage = Crops[j].Product.TaxPerUnitPercentage / 2;
                        } else
                        {
                            productTaxPerUnitPercentage = Crops[j].Product.TaxPerUnitPercentage;
                        } 
                    }
                }
            }
            Console.WriteLine("Nombre del Farmer: " + farmerName);
            Console.WriteLine("Genero del Farmer: " + farmerGender);
            Console.WriteLine("Nombre del producto: " + productName);
            Console.WriteLine("Unidades por kilometro: " + productUnitPerKilometer);
            Console.WriteLine("Valor unitario del producto: " + productUnitPrice);
            Console.WriteLine("Tasa de impuesto: " + productTaxPerUnitPercentage);
            Console.WriteLine("Extension del cultivo: " + cropExtension);
            Console.WriteLine("Precio de venta en dolares: " + valuesell);
        }
    }
}
