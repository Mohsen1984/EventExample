
using System.Threading;
using System;
namespace Event
{
    public class VideoEventArgs : EventArgs
    {
        public string videoname { get; set; }
    }
    public class VideoConverter
    {

        public delegate void SendMessageEventHandler(object o, VideoEventArgs Event);
        public event SendMessageEventHandler VideoConverted;
        public VideoEventArgs _videoEventArgs;
        private Video _video;


        public VideoConverter()
        {
        }

        public VideoConverter(Video v, VideoEventArgs _vEventArgs)
        {

            _video = v;
            _videoEventArgs = _vEventArgs;
        }

        public void DoConvert()
        {
            //Some Code TO Convert Video
            if (_video != null && _videoEventArgs != null)
            {
                System.Console.WriteLine("Video Converted");
                _videoEventArgs.videoname = _video.VideoName;
                OnVideoConverted(_videoEventArgs);
            }
        }

        protected virtual void OnVideoConverted(VideoEventArgs _eventArgs)
        {
            if (VideoConverted != null)
            {
                VideoConverted(this, _eventArgs);
            }
        }
    }
}