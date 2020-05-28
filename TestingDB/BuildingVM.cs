using System;
using System.Collections.Generic;
using System.Text;

namespace TestingDB
{
    class BuildingVM
    {


        public List<BuildingModel> Buildinglist { set; get; }

        public BuildingVM()
        {
            Buildinglist = new List<BuildingModel>();
            FillData();
        }

        public void FillData()
        {

            BuildingModel b1 = new BuildingModel("FCIT");
            BuildingModel b2 = new BuildingModel("Scince Faculty");
            BuildingModel b3 = new BuildingModel("Campus Library");


            Buildinglist.Add(b1);
            Buildinglist.Add(b2);
            Buildinglist.Add(b3);

        }

    }
}
