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


        public static void printOut(String routeName, String minimumLevel, String maximumLevel, String minimumDurability, String minimumBagslots)
        {

            String nameOfRoute = routeName;
            String minLevel = minimumLevel;
            String maxLevel = maximumLevel;
            String minDurability = minimumDurability;
            String minBagSlots = minimumBagslots;

            String writeToFile = "<HBProfile>" + "\r\n" + "    <Name>" + nameOfRoute + "</Name>" + "\r\n" + "    <MinLevel>" + minLevel + "</MinLevel>" + "\r\n";

            System.IO.File.WriteAllText(@"C:\Users\Erik\Desktop\" + nameOfRoute + ".xml", writeToFile);
        }
    }
}
