using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileBuddy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }


        public static void printOut(String routeName, String minimumLevel, String maximumLevel, String minimumDurability, String minimumBagslots, String hotspots)
        {

            String writeToFile =
                "<HBProfile>\r\n\r\n" + "    <Name>" + routeName + "</Name>\r\n" + 
                "    <MinLevel>" + minimumLevel + "</MinLevel>\r\n" +
                "    <MaxLevel>" + minimumLevel + "</MaxLevel>\r\n" +
                "    <MinDurability>" + minimumDurability + "</MinDurability>\r\n" +
                "    <MinFreeBagSlots>" + minimumBagslots + "</MinFreeBagSlots>\r\n\r\n" +
                "    <Hotspots>" +
                hotspots + "\r\n" +
                "    </Hotspots>\r\n\r\n" +
                "</HBProfile>";

            System.IO.File.WriteAllText(@"C:\Users\Erik\Desktop\" + routeName + ".xml", writeToFile);
        }

        public static string printOutArray(String[] coordinates)
        {
            String coordinateRoute = "";
            for (int i = 0; coordinates[i] != null; i++)
            {
                coordinateRoute = coordinateRoute + "\r\n        " + coordinates[i];
            }

            return coordinateRoute;
        }
    }
}
