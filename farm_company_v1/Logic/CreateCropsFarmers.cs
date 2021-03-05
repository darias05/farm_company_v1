using System;
using System.Collections.Generic;
using System.Text;
using farm_company_v1.DAO;
using farm_company_v1.DTO;

namespace farm_company_v1.Logic
{
    public class CreateCropsFarmers
    {
        public List<Dto_Crop> CreateCropFarmer(List<Dto_Product> Products, List<Dto_Farmer> Farmers)
        {
            List<int> Extension = new List<int>()
            {
                5, 7, 8, 13, 5, 18, 21
            };

            List<string> Status = new List<string>()
            {
                "sold out", "sold out", "available", "sold out", "sold out", "sold out", "sold out"
            };

            Dao_Crop dao_Crop = new Dao_Crop();
            List<Dto_Crop> List_Crops = dao_Crop.CreateCropFarmer(Products, Extension, Farmers, Status);

            return List_Crops;
        }
    }
}
