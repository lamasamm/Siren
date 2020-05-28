using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestingDB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FloorDetails : ContentPage
    {

        public FloorDetails(FloorModel selectedItem)
        {
            InitializeComponent();


            floor_title.Text = selectedItem.Title;
            CMC_NUM.Text = selectedItem.CMC;
            FGR_NUM.Text = selectedItem.FireGrowthRate;
            SUC_NUM.Text = selectedItem.EvacSuccsess;
            Crowd_Map.Source = selectedItem.CrowdMap;

        }


    }
}