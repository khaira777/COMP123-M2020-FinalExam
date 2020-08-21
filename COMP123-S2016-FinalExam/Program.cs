using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


//  Programming-2
//  Gurkirat Singh Khaira
//  #301112565
//  Final exam
//
//
namespace COMP123_M2020_FinalExam
{
    public static class Program
    {
        // PUBLIC/PRIVATE STATIC FIELDS
        public static Character character = new Character();
        public static AbilityGeneratorForm abilitygeneratorform;
        private static AboutBox aboutbox;
        public static FinalForm finalform;
        public static GenerateNameForm generatenameform;
        public static RaceAndClassForm raceandclassform;
        public static SplashForm splashform;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //  INSTANTIATING THE FORM OBJECTS
            splashform = new SplashForm();
            abilitygeneratorform = new AbilityGeneratorForm();
            aboutbox = new AboutBox();
            finalform = new FinalForm();
            generatenameform = new GenerateNameForm();
            raceandclassform = new RaceAndClassForm();

            //  DECLARING WHICH FORM WILL APPEAR FIRST
            Application.Run(splashform);
        }
    }
}
