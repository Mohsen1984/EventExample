
using System.Threading;
using System;
namespace Event
{
    public class VideoEventArgs :EventArgs
    {
           public string videoname { get; set; }
    }
    public class VideoConverter
    {
        private Video _video;
        public VideoEventArgs _videoEventArgs=new  VideoEventArgs();
        public delegate void SendMessageEventHandler(object o, VideoEventArgs Event);
        public event SendMessageEventHandler VideoConverted;
        public VideoConverter()
        {
        }

        public VideoConverter(Video v)
        {
            _video=v;
           
        }

        public void DoConvert()
        {
            System.Console.WriteLine("Video Converted");
            _videoEventArgs.videoname=_video.VideoName;
            OnVideoConverted(_videoEventArgs);
        }

        protected virtual void OnVideoConverted(VideoEventArgs _eventArgs)
        {
                if(VideoConverted!= null)
                {
                    VideoConverted(this,_eventArgs);
                }
        }
    }
}