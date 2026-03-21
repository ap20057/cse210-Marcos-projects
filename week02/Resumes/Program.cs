
    Job job1 = new Job();
    job1._jobTitle = "Software Engineer ";
    job1._company = "Microsoft";
    job1._jobTitle1 = "Manager ";
    job1._company = "Apple";
    Resume resume1 = new Resume();
    resume1._personName = "Marcos";
  
    Console.WriteLine(job1.DisplayJobInformation({_jobTitle}));
    Console.WriteLine(job1.DisplayJobInformation({ _jobTitle1}));

}

using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}