namespace tpmodul6_1302210014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo vidio = new SayaTubeVideo("Tutorial Design By Contract - Muhammad Isa Al Anshori");
            vidio.IncreasePlayCount(420);
            vidio.PrintVideoDetails();
        }
    }
}