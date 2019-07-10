using System;
namespace SchoolTracker
{
    public class Stats
    {
        public void Start()
        {
            Program.Posted += DataPosted;
        }

        void DataPosted()
        {
            Console.WriteLine("Data posted, run stats");
        }

        public Stats()
        {
        }
    }
}
