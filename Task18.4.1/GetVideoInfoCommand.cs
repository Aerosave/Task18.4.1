using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;

namespace Task18._4._1
{
    public class GetVideoInfoCommand : ICommand
    {
        private readonly string _videoUrl;

        public GetVideoInfoCommand(string videoUrl)
        {
            _videoUrl = videoUrl;
        }

        public async Task ExecuteAsync()
        {
            var youtube = new YoutubeClient();
            var video = await youtube.Videos.GetAsync(_videoUrl);

            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Description: {video.Description}");
        }
    }
}