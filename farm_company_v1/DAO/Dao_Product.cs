using System;
using System.Collections.Generic;
using System.Text;
using farm_company_v1.DTO;

namespace farm_company_v1.DAO
{
    public class Dao_Product
    {
        public List<Dto_Product> CreateProduct(List<string> Name, List<int> UnitPrice, List<int> UnitPerKilometer,
                                   List<double> TaxPerUnitPercentage)
        {
            List<Dto_Product> Product = new List<Dto_Product>();

            for (int i = 0; i < Name.Count; i++)
            {
                Product.Add(new Dto_Product() { Name = Name[i], UnitPrice = UnitPrice[i], UnitPerKilometer = UnitPerKilometer[i], 
                            TaxPerUnitPercentage = TaxPerUnitPercentage[i] });
            }

            return Product;
        }
    }
}
