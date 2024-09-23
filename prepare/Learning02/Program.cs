using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2009;
        job1._endYear = 2015;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2014;
        job2._endYear = 2020;

        //job1.Display();
        //job2.Display();

        Resume resume = new Resume();
        resume._name = "Fred Turner";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}