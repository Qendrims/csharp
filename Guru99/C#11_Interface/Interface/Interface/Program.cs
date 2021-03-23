using System;

namespace Interface
{
    interface Guru99Interface
    {
        void SetTutorial(int pID, string pName);
        String GetTutorial();
    }

    class Guru99Tutorial : Guru99Interface
    {
        protected int TutorialID;
        protected string TutorialName;

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
            Guru99Tutorial pTutor = new Guru99Tutorial();
            pTutor.SetTutorial(1, ".Net by Guru99");
            Console.WriteLine(pTutor.GetTutorial());
        }
    }
}
