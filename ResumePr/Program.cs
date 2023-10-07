namespace ResumePr
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume[] resumes = MockedData.GetMockedResumes();

            // Neatly print out the populated data
            foreach (var resume in resumes)
            {
                Console.WriteLine(resume);
            }
        }
    }
}
