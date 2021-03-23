using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Tutorial
    {
        public int TutorialID;
        public string TutorialName;

        public Tutorial()
        {
            TutorialID = 0;
            TutorialName = "Default";
        }
        public void SetTutorial(int pID, string pName)
        {
            TutorialID = pID;
            TutorialName = pName;
        }
        public String GetTutorial()
        {
            return TutorialName;
        }
        static void Main(string[] args)
        {
            Tutorial pTutor = new Tutorial();
            Console.WriteLine(pTutor.GetTutorial());

            Console.ReadKey();
        }
    }
}
