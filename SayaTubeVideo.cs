using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(title != null && title.Length < 100, "Judul video tidak valid!");
            this.title = title;
            id = rnd.Next();
            playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "Penambahan play count melebihi 10 juta");
            try
            {
                playCount = checked(playCount + count);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Jumlah play count melebihi batas integer");
            }
            
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("\"" + title + "\" - " + id + " - Viewed: " + playCount + "x");
        }
    }
}
