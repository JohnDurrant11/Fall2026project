using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "manager";
        job2._startYear = 2022;
        job2._endYear = 2023;


        Resume myResume = new Resume();
        myResume._userName = "John Durrant";

        myResume._previousJobs.Add(job1);
        myResume._previousJobs.Add(job2);

        myResume.DisplayResume();


    }
}