namespace GarageTests
{
    public class GarageTests
    {


        static string CurrentWorkingDirectory = Environment.CurrentDirectory;
        static string SolutionFolder = Directory.GetParent(CurrentWorkingDirectory).Parent.Parent.Parent.FullName;
        static string MainProjectFolder = Directory.GetParent(CurrentWorkingDirectory).Parent.Parent.FullName;

        string[] directories = Directory.GetDirectories(SolutionFolder);
        //FileInfo[] fileList = Directory.GetParent(MainProjectFolder).GetFiles();
        //File projectFiles = Directory.EnumerateFiles(MainProjectFolder);
        string[] projectFiles = Directory.EnumerateFiles(MainProjectFolder).ToArray();


        [Fact]
        public void TestofGary()
        {
            GarageApp.Handlers.GarageHandler gh = new GarageApp.Handlers.GarageHandler();

            //GarageApp.Models.Garage<Vehicle> garage = gh.Build(27); /* Create a garage of capacity 27 */

            //Assert.NotNull(garage);        
            
        }


        [Fact]
        public void number_of_wheels_is_in_range_0_to_16()
        {
            GarageApp.Models.Car vehicle = new GarageApp.Models.Car();
            int wheels = vehicle.nWheels;

            Assert.InRange<int>(wheels, 0, 16);
        }

        [Fact]
        public void no_boat_should_have_any_wheels_shouldit()
        {
            GarageApp.Models.Boat vehicle = new GarageApp.Models.Boat();
            int wheels = vehicle.nWheels;

            Assert.Equal(0, wheels);
        }

        [Fact]
        public void a_boat_should_have_a_proppeller_tho()
        {
            GarageApp.Models.Boat vehicle = new GarageApp.Models.Boat ();

            bool hasRudder = vehicle.hasRudder;

            Assert.True(hasRudder);
        }


    }
}