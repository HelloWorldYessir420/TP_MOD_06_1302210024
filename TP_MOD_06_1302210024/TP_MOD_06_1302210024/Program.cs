using TP_MOD_06_1302210024;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – [Habli Zulvana Ath-Thaariq]");
            video.PrintVideoDetails();

            video.IncreasePlayCount(500);
            video.PrintVideoDetails();

            video.IncreasePlayCount(9999999);
            video.PrintVideoDetails();

            video.IncreasePlayCount(-100);
            video.PrintVideoDetails();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}