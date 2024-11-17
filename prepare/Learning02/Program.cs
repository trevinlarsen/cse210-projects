using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Job instances
        Job job1 = new Job();
        job1._jobTitle = "Cloud Architect";
        job1._company = "Microsoft";
        job1._startYear = 2017;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "McDonalds";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Create Resume instance
        Resume myResume = new Resume();
        myResume._name = "Joe John";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display the resume
        myResume.Display();
    }
}
