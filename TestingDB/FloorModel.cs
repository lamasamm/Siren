using System;
using System.Collections.Generic;
using System.Text;

namespace TestingDB
{
   public class FloorModel
    {

        public FloorModel(String Title_, String CMC_, String FireGrowthRate_, String EvacSuccsess_, String CrowdMap_)
        {
            Title = Title_;
            CMC = CMC_;
            FireGrowthRate = FireGrowthRate_;
            EvacSuccsess = EvacSuccsess_;
            CrowdMap = CrowdMap_;

        }


        public String Title { get; set; }
        public String CMC { get; set; }
        public String FireGrowthRate { get; set; }
        public String EvacSuccsess { get; set; }
        public String CrowdMap { get; set; }



    }
}
