using System;
using System.Collections.Generic;
using System.Text;
using farm_company_v1.DTO;

namespace farm_company_v1.DAO
{
    public class Dao_Crop
    {
        public List<Dto_Crop> CreateCropFarmer(List<Dto_Product> Product, List<int> Extension, List<Dto_Farmer> Farmer, List<string> Status)
        {
            List<Dto_Crop> Crop = new List<Dto_Crop>();
            int n = 0;
            int i = 0;
            int Existencias = 0;

            while (i < Product.Count)
            {
                if (n < Farmer.Count)
                {
                    for (int j = 0; j < Crop.Count; j++)
                    {
                        if (Crop[j].Farmer.Document == Farmer[n].Document)
                        {
                            Existencias++;
                        }
                    }

                    if (Existencias > 0)
                    {
                        if (Farmer[n].Capitalist == "True")
                        {
                            Crop.Add(new Dto_Crop()
                            {
                                Product = Product[i],
                                Extension = Extension[i],
                                Farmer = Farmer[n],
                                Status = Status[i]
                            });
                            i++;
                        }
                    } else {
                        Crop.Add(new Dto_Crop()
                        {
                            Product = Product[i],
                            Extension = Extension[i],
                            Farmer = Farmer[n],
                            Status = Status[i]
                        });
                        i++;
                    }

                    n++;
                } else {
                    n = 0;
                    for (int j = 0; j < Crop.Count; j++)
                    {
                        if (Crop[j].Farmer.Document == Farmer[n].Document)
                        {
                            Existencias++;
                        }
                    }

                    if (Existencias > 0)
                    {
                        if (Farmer[n].Capitalist == "True")
                        {
                            Crop.Add(new Dto_Crop()
                            {
                                Product = Product[i],
                                Extension = Extension[i],
                                Farmer = Farmer[i],
                                Status = Status[i]
                            });
                            i++;
                        }
                    }
                    else
                    {
                        Crop.Add(new Dto_Crop()
                        {
                            Product = Product[i],
                            Extension = Extension[i],
                            Farmer = Farmer[n],
                            Status = Status[i]
                        });
                        i++;
                    }

                    n++;
                }
            }
            return Crop;
        }
    }
}