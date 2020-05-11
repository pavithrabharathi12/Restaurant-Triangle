using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;

namespace RestaurantTriangle
{
    public static class Program
    {
        public static List<PointLatLng> RestaurantLocationList=new List<PointLatLng>();
        public static List<string> RestaurantNameList = new List<string>();

        [STAThread]
        public static void Main()
        {
            ShowRestaurants();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MapForm());
        }

        private static void ShowRestaurants()
        {
            //Adding restaurants to list
            var response = ZomatoInfo.GetRestaurants();
            var restaurants = response.Restaurants;
            foreach (var r in restaurants)
            {
                var restaurant = r.Restaurant;
                var lat = Convert.ToDouble(restaurant.Location.Latitude); //Adding restaurant latitude to the list
                var lng = Convert.ToDouble(restaurant.Location.Longitude); //Adding restaurant longitude to the list
                RestaurantLocationList.Add(new PointLatLng(lat, lng));
                RestaurantNameList.Add(r.Restaurant.Name);
            }
        }

    }
}
