using System;
using System.Collections.Generic;
using System.Text;
using farm_company_v1.DTO;

namespace farm_company_v1.DAO
{
    public class Dao_Farmer
    {
        public List<Dto_Farmer> CreateFarmer(List<string> Name, List<int> Document, 
                                        List<string> Gender, List<int> Stratum, List<string> Capitalist)
        {
            List<Dto_Farmer> Farmer = new List<Dto_Farmer>();

            for (int i = 0; i < Name.Count; i++)
            {
                Farmer.Add(new Dto_Farmer() { Name = Name[i], Document = Document[i], Gender = Gender[i], 
                            Stratum = Stratum[i], Capitalist = Capitalist[i] });
            }

            return Farmer;
        }
    }
}