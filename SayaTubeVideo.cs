using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302210014
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        static private Random rnd = new Random();

        public SayaTubeVideo(string title)
        {
            this.title = title;
            id = rnd.Next();
            playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("\"" + title + "\" - " + id + " - Viewed: " + playCount + "x");
        }
    }
}
