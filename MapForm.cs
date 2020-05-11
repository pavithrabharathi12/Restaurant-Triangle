using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;

namespace RestaurantTriangle
{
    public partial class MapForm : Form
    {
        #region Constructor
        public MapForm()
        {
            InitializeComponent();
            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl1.DragButton = MouseButtons.Left;
        }
        #endregion

        #region Method for Getting All Restaurants List from Console 
        public static List<PointLatLng> GettingAllRestaurantsList()
        {
            try
            {
                var _restaurantsList = Program.RestaurantLocationList.ToList();
                return _restaurantsList;
            }
            catch
            {
                return null;
            }
        }

        public static List<string> GettingAllRestaurantNamesList()
        {
            try
            {
                var RestaurantNameList = Program.RestaurantNameList.ToList();
                return RestaurantNameList;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Method For Calculating Area of Triangle 
        private double AreaOfTriangle(PointLatLng restnearby, PointLatLng restFarBy)
        {
            try
            {
                var startpoint = new PointLatLng(17.5246686012, 73.5244691011);
                var Ax = startpoint.Lat;
                var Ay = startpoint.Lng;
                var Bx = restFarBy.Lat;
                var By = restFarBy.Lng;
                var Cx = restnearby.Lat;
                var Cy = restnearby.Lng;
                var P1 = By - Cy;
                var P2 = Cy - Ay;
                var P3 = Ay - By;
                var areaOfTriangle = Math.Sqrt(((Ax * P1) + (Bx * P2) + (Cx * P3)) / 2);
                return areaOfTriangle;
            }
            catch
            {
                return default;
            }
        }
        #endregion

        #region Button Load Task 1
        private void Load_Map_Click_1(object sender, EventArgs e)
        {
            try
            {
                #region Data Members
                var AllRestaurantList = new List<PointLatLng>();
                var RestaurantNameList = new List<string>();
                var EachRestaurantDistanceList = new List<double>();
                var _3FinalLocations = new List<PointLatLng>();

                var routes = new GMapOverlay("routes");
                var NearestRestaurantLocation = new PointLatLng();
                var FarthestRestaurantLocation = new PointLatLng();
                var NearestRestaurantName = string.Empty;
                var FarthestRestaurantName=string.Empty;
                #endregion

                #region Initial Latitude and Longitude
                var initialLatitude = Convert.ToDouble(txtlat.Text);
                var initialLongitude = Convert.ToDouble(txtlng.Text);
                var initialLatAndLng = new PointLatLng(initialLatitude, initialLongitude);
                #endregion

                #region Marking All Restaurants in the Map in Red Color

                AllRestaurantList = GettingAllRestaurantsList();
                RestaurantNameList = GettingAllRestaurantNamesList();

                for (int index = 0; index < AllRestaurantList.Count; index++)
                {
                    var marker = new GMarkerGoogle(AllRestaurantList[index], GMarkerGoogleType.red);
                    routes.Markers.Add(marker);
                    gMapControl1.Position = AllRestaurantList[index];
                }
                #endregion

                #region  Attaining Distance between Starting Location And Each Restaurant Location

                foreach (PointLatLng t in AllRestaurantList)
                {
                    var _listOfStartAndEndPoint = new List<PointLatLng> { initialLatAndLng, t };
                    var route = new GMapRoute(_listOfStartAndEndPoint, "route");
                    EachRestaurantDistanceList.Add(route.Distance);
                }
                var MinToMaxDistance = EachRestaurantDistanceList.OrderBy(x => x).ToList();
                var MinimumDistance = MinToMaxDistance[0]; //nearest distance
                var MaximumDistance = MinToMaxDistance[EachRestaurantDistanceList.Count - 1]; //farthest distance
                #endregion

                #region Attaining Nearest And Farthest Restaurants

                for (int index = 0; index < EachRestaurantDistanceList.Count - 1; index++)
                {
                    if (EachRestaurantDistanceList[index] == MinimumDistance)
                    {
                        NearestRestaurantLocation = AllRestaurantList[index];
                        NearestRestaurantName = RestaurantNameList[index];
                    }
                    else if (EachRestaurantDistanceList[index] == MaximumDistance)
                    {
                        FarthestRestaurantLocation = AllRestaurantList[index];
                        FarthestRestaurantName = RestaurantNameList[index];
                    }
                }
                #endregion

                #region Starting Location, Nearest Restaurant and Farthest Restaurant in a list

                _3FinalLocations = new List<PointLatLng>
                {
                initialLatAndLng,
                FarthestRestaurantLocation,
                NearestRestaurantLocation
                };
                var _3FinalName = new List<string>
                {
                "Starting Location - Home",
                "Restaurant name: "+FarthestRestaurantName,
                "Restaurant name: "+NearestRestaurantName
                };
                #endregion

                #region Marking 3 Final Locations in a Map in Green Color

                for (int index = 0; index < _3FinalLocations.Count;index++)
                {
                    var marker = new GMarkerGoogle(_3FinalLocations[index], GMarkerGoogleType.green)
                    {
                        ToolTipText = $"\n{_3FinalName[index]},\nLatitude: {gMapControl1.Position.Lat},\nLongitude: { gMapControl1.Position.Lng}"
                    };
                    routes.Markers.Add(marker);
                    gMapControl1.Position = _3FinalLocations[index];
                }
                #endregion

                #region Drawing Route Line for 3 Location In Triangle

                _3FinalLocations.Add(_3FinalLocations[0]);
                GMapRoute restuarantGraph = new GMapRoute(_3FinalLocations, "A walk in the park")
                {
                    Stroke = new Pen(Color.Red, 3) //Distance line point
                };
                routes.Routes.Add(restuarantGraph);
                #endregion

                #region Task 1- Area of Triangle, Time taken For Walking all the 3 Locations.

                // Displaying Distance in Label.
                var _3Locationdistance = Convert.ToSingle(restuarantGraph.Distance);
                labelDistance.Text = _3Locationdistance.ToString(".00") + " KM";

                //Displaing Time in Label.
                var time_taken = _3Locationdistance / 5;
                labelTime.Text = time_taken.ToString(".00") + " Hours";

                //Displaying Area of Triangle in Label.
                labelarea.Text = AreaOfTriangle(NearestRestaurantLocation, FarthestRestaurantLocation).ToString("0.0000") + " Square.Units";
                gMapControl1.Overlays.Add(routes);
                #endregion
            }
            catch (Exception)
            {
                //ignored
            }

        }
    #endregion

        #region Button Load Task 2

        private void BtnLoadCarRoute_Click(object sender, EventArgs e)
        {
            try
            {
                #region Data Members
                var AllRestaurantList = new List<PointLatLng>();
                var RestaurantNameList = new List<string>();
                var EachRestaurantDistanceList = new List<double>();
                var _3FinalLocations = new List<PointLatLng>();

                var routes = new GMapOverlay("routes");
                var NearestRestaurantLocation = new PointLatLng();
                var FarthestRestaurantLocation = new PointLatLng();
                var NearestRestaurantName = string.Empty;
                var FarthestRestaurantName = string.Empty;
                #endregion

                #region Initial Latitude and Longitude

                var initialLatitude = Convert.ToDouble(txtlat.Text);
                var initialLongitude = Convert.ToDouble(txtlng.Text);
                var initialLatAndLng = new PointLatLng(initialLatitude, initialLongitude);

                #endregion

                #region Marking All Restaurants in the Map in Red Color

                AllRestaurantList = GettingAllRestaurantsList();
                RestaurantNameList = GettingAllRestaurantNamesList();

                foreach (PointLatLng t in AllRestaurantList)
                {
                    var marker = new GMarkerGoogle(t, GMarkerGoogleType.red);
                    routes.Markers.Add(marker);
                    gMapControl1.Position = t;
                }
                #endregion

                #region  Attaining Distance between Starting Location And Each Restaurant Location

                foreach (PointLatLng t in AllRestaurantList)
                {
                    var _listOfStartAndEndPoint = new List<PointLatLng> { initialLatAndLng, t };
                    var route = new GMapRoute(_listOfStartAndEndPoint, "route");
                    EachRestaurantDistanceList.Add(route.Distance);
                }
                var MinToMaxDistance = EachRestaurantDistanceList.OrderBy(x => x).ToList();
                var MinimumDistance = MinToMaxDistance[0]; //nearest distance
                var MaximumDistance = MinToMaxDistance[EachRestaurantDistanceList.Count - 1]; //farthest distance
                #endregion

                #region Attaining Nearest And Farthest Restaurants

                for (int index = 0; index < EachRestaurantDistanceList.Count - 1; index++)
                {
                    if (EachRestaurantDistanceList[index] == MinimumDistance)
                    {
                        NearestRestaurantLocation = AllRestaurantList[index];
                        NearestRestaurantName = RestaurantNameList[index];
                    }
                    else if (EachRestaurantDistanceList[index] == MaximumDistance)
                    {
                        FarthestRestaurantLocation = AllRestaurantList[index];
                        FarthestRestaurantName = RestaurantNameList[index];
                    }
                }
                #endregion

                #region Starting Location, Nearest Restaurant and Farthest Restaurant in a list

                _3FinalLocations = new List<PointLatLng>
                {
                initialLatAndLng,
                FarthestRestaurantLocation,
                NearestRestaurantLocation
                };
                var _3FinalName = new List<string>
                {
                "Starting Location - Home",
                "Restaurant name: "+FarthestRestaurantName,
                "Restaurant name: "+NearestRestaurantName
                };
                #endregion

                #region Marking 3 Final Locations in a Map in Blue Color

                for (int index = 0; index < _3FinalLocations.Count; index++)
                {
                    var marker = new GMarkerGoogle(_3FinalLocations[index], GMarkerGoogleType.blue)
                    {
                        ToolTipText = $"\n{_3FinalName[index]},\nLatitude: {gMapControl1.Position.Lat},\nLongitude: { gMapControl1.Position.Lng}"
                    };
                    routes.Markers.Add(marker);
                    gMapControl1.Position = _3FinalLocations[index];
                }

                #endregion

                #region Drawing Route Line for 3 Location In Triangle

                _3FinalLocations.Add(_3FinalLocations[0]);
                GMapRoute restuarantGraph = new GMapRoute(_3FinalLocations, "A car route")
                {
                    Stroke = new Pen(Color.Green, 3) //Distance line point
                };
                routes.Routes.Add(restuarantGraph);
                #endregion

                #region Area of Triangle, Time taken for all the 3 Locations.

                // Displaying Distance in Label.
                var _3Locationdistance = Convert.ToSingle(restuarantGraph.Distance);
                labelDistance.Text = _3Locationdistance.ToString(".00") + " KM";

                //Displaing Time in Label.
                var time_taken = _3Locationdistance / 5;
                labelTime.Text = time_taken.ToString(".00") + " Hours";

                //Displaying Area of Triangle in Label.
                labelarea.Text = AreaOfTriangle(NearestRestaurantLocation, FarthestRestaurantLocation).ToString("0.0000") + " Square.Units";
                gMapControl1.Overlays.Add(routes);
                #endregion

                #region Task 2

                //var rt = GMapProviders.GoogleMap.GetDirections(out GDirections gDirections, _3FinalLocations[0], _3FinalLocations[1], false,
                //    false, false, false, false);
                //var r = new GMapRoute(gDirections.Route, "A car route");
                ////r.Stroke = new Pen(Color.Red, 3); //Distance line point
                //routes.Routes.Add(r);


                #endregion

                #region Drawing Route Line for 3 Location In Triangle

                //_3FinalLocations.Add(_3FinalLocations[0]);
                //GMapRoute restuarantGraph = new GMapRoute(_3FinalLocations, "Route");
                //restuarantGraph.Stroke = new Pen(Color.Red, 3); //Distance line point
                //routes.Routes.Add(restuarantGraph);

                #endregion

            }
            catch (Exception)
            {
                //ignored
            }
        }
        #endregion

        #region Button Clear

        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                if (gMapControl1.Overlays.Count > 0)
                {
                    int remove = gMapControl1.Overlays.Count - 1;
                    gMapControl1.Overlays.RemoveAt(remove);
                    gMapControl1.Refresh();
                }

                txtlat.Text = "";
                txtlng.Text = "";
                labelDistance.Text = labelTime.Text = labelarea.Text = "";
            }
            catch
            {
                //ignored
            }
        }
        #endregion

        #region Button load Restaurants

        private void BtnLoadRestaurants_Click(object sender, EventArgs e)
        {
            try
            {
                var routes = new GMapOverlay("routes");

                var AllRestaurantList = GettingAllRestaurantsList();
                foreach (PointLatLng t in AllRestaurantList)
                {
                    var marker = new GMarkerGoogle(t, GMarkerGoogleType.red);
                    routes.Markers.Add(marker);
                    gMapControl1.Position = t;
                }
                gMapControl1.Overlays.Add(routes);
            }
            catch
            {
                //ignored
            }
        }
        #endregion
    }
}
