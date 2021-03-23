using System;

namespace Inheritance
{
    public class Tutorial
    {
        protected int TutorialID;
        protected string TutorialName;

        public void SetTutorial(int pID , String pName)
        {
            TutorialID = pID;
            TutorialName = pName;
        }

        public String GetTutorial()
        {
            return TutorialName;
        }
    }
    public class Guru99Tutorial : Tutorial
    {
        public void RenameTutorail(String pNewName)
        {
            TutorialName = pNewName;
        }
        static void Main(string[] args)
        {
            Guru99Tutorial pTutor = new Guru99Tutorial();
            pTutor.RenameTutorail(".Net by Guru99");
            Console.WriteLine(pTutor.GetTutorial());
        }
    }
}
