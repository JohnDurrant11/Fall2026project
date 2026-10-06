public class Resume
{
    public string _userName = "";
    public List<Job> _previousJobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_userName}");
        Console.WriteLine($"Jobs:");

        foreach (Job job in _previousJobs)
        {
            job.DisplayCompanyDetails();
        }
    }
}