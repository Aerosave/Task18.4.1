using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Task18._4._1
{
    public class DownloadVideoCommand : ICommand
    {
        private readonly string _videoUrl;
        private readonly string _outputFilePath;

        public DownloadVideoCommand(string videoUrl, string outputFilePath)
        {
            _videoUrl = videoUrl;
            _outputFilePath = outputFilePath;
        }

        public async Task ExecuteAsync()
        {
            var youtube = new YoutubeClient();
            await youtube.Videos.DownloadAsync(_videoUrl, _outputFilePath, builder => builder.SetPreset(ConversionPreset.UltraFast));

            Console.WriteLine("загрузилося");
        }
    }
}
