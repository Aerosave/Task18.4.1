using YoutubeExplode;
using YoutubeExplode.Videos;

namespace Task18._4._1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("URL видео для скачивания с Ютуп:");
            string videoUrl = Console.ReadLine();

            Pult pult = new Pult();

            // Получение информации о видео
            pult.SetCommand(new GetVideoInfoCommand(videoUrl));
            await pult.PressButtonAsync();

            // Скачивание видео
            string outputFilePath = "video.mp4";
            pult.SetCommand(new DownloadVideoCommand(videoUrl, outputFilePath));
            await pult.PressButtonAsync();
        }
    }
}
