using System;
using System.Collections.Generic;
using System.Text;

namespace TestingDB
{
    class FloorVM
    {

        public List<FloorModel> Floorlist { set; get; }


        public FloorVM()
        {
            Floorlist = new List<FloorModel>();
            fillData();
        }
        public void fillData()
        {

            FloorModel first = new FloorModel("First Floor", "15%", "10%", "90%", "f1.png");
            FloorModel Second = new FloorModel("Second Floor", "20%", "20%", "45%", "f2.png");
            FloorModel Third = new FloorModel("Third Floor", "49%", "30%", "60%", "f3.png");


            Floorlist.Add(first);
            Floorlist.Add(Second);
            Floorlist.Add(Third);

        }
    }
}
