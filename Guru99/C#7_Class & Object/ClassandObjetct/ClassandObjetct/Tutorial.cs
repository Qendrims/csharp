using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ClassandObjetct
{
    class Tutorial
    {
        int TutorialID;
        string TutorialName;
        
        public void SetTutorial(int pID , String pName)
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
            pTutor.SetTutorial(1, ".Net");

            Console.WriteLine(pTutor.GetTutorial());

            Console.ReadKey();
        
        }
    }
}
