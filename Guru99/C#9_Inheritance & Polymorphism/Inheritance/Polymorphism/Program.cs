using System;

namespace Polymorphism
{
    class Tutorial
    {
        public int TutorialID;
        public string TutorialName;
        public void SetTutorial(int pID, string pName)
        {
            TutorialID = pID;
            TutorialName = pName;
            
        }
        public void SetTutorial(string pName)
        {
            TutorialName = pName;
        }
        public String GetTutorial()
        {
            return TutorialName;
        }

        static void Main(string[] args)
        {
            Tutorial pTutor = new Tutorial();

            pTutor.SetTutorial(1, "First Tutorial");
            Console.WriteLine(pTutor.GetTutorial());

            pTutor.SetTutorial("Second Tutorial");
            Console.WriteLine(pTutor.GetTutorial());
        }
    }
}
