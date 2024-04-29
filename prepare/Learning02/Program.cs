using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job _job1 = new Job();
        Job _job2 = new Job();

        _job1._jobTitle = "Software Engineer";
        _job1._company = "Microsoft";
        _job1._startYear = 2024;
        _job1._endYear = 2030;

        _job2._jobTitle = "Manager";
        _job2._company = "Apple";
        _job2._startYear = 2030;
        _job2._endYear = 2040;

        //_job1.Display();
        //_job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Erick Flores";
        myResume._jobs.Add(_job1);
        myResume._jobs.Add(_job2);

        myResume.Display();
    }
}