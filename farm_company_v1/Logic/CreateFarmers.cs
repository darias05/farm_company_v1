using System;
using System.Collections.Generic;
using System.Text;
using farm_company_v1.DAO;
using farm_company_v1.DTO;

namespace farm_company_v1.Logic
{
    public class CreateFarmers
    {
        public List<Dto_Farmer> CreateFarmer()
        {
            List<string> Name = new List<string>()
            {
                "Cristian Andres", "Juan Solarte", "Camila Martinez", "Angela Cardona", "Dylan Arias"
            };

            List<int> Document = new List<int>()
            {
                1234, 2345, 3456, 4567, 5678
            };

            List<string> Gender = new List<string>()
            {
                "M", "M", "F", "F", "M"
            };

            List<int> Stratum = new List<int>()
            {
                3, 2, 3, 4, 5
            };

            List<string> Capitalist = new List<string>()
            {
                "False", "False", "False", "False", "True"
            };

            Dao_Farmer Obj_Dao_Farmer = new Dao_Farmer();
            List<Dto_Farmer> List_Farmers = Obj_Dao_Farmer.CreateFarmer(Name, Document, Gender, Stratum, Capitalist);

            return List_Farmers;
        }
    }
}
