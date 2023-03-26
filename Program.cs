namespace tpmodul6_1302210014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo vidio;
            // vidio = new SayaTubeVideo(null);
            // vidio = new SayaTubeVideo("Helloooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo");
            vidio = new SayaTubeVideo("Tutorial Design By Contract - Muhammad Isa Al Anshori");
            // vidio.IncreasePlayCount(10000001);
            vidio.IncreasePlayCount(420);
            vidio.PrintVideoDetails();
            for (int i = 0; i < 215; i++)
            {
                vidio.IncreasePlayCount(10000000);
            }
            vidio.PrintVideoDetails();
        }
    }
}