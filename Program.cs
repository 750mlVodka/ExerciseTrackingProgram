class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("10 Dic 2024", 30, 4.8));
        activities.Add(new Cycling("06 Ene 2025", 25, 15.0));
        activities.Add(new Swimming("14 Feb 2025", 40, 30));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
