using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;

namespace Task18._4._1
{
   public interface ICommand
    {
        Task ExecuteAsync();
    }
}
