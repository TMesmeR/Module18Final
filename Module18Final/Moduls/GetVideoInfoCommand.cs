using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace Module18Final.Moduls
{
    public class GetVideoInfoCommand : ICommand
    {
        private readonly YoutubeClient _youtubeClient;
        private readonly string _videoUrl;

        public GetVideoInfoCommand(YoutubeClient youtubeClient, string videoUrl)
        {
            _youtubeClient = youtubeClient;
            _videoUrl = videoUrl;
        }

        public async Task ExecuteAsync()
        {
            var video = await _youtubeClient.Videos.GetAsync(_videoUrl);
            Console.WriteLine($"Название: {video.Title}");
            Console.WriteLine($"Описание: {video.Description}");
        }
    }
}
