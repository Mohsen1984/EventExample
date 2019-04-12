using System;

namespace Event
{

    class Program
    {
        static void Main(string[] args)
        {
            Video _v=new Video("Jomanji");
            VideoConverter _videoConverter=new VideoConverter(_v);
            SendMessage _sendMessage=new SendMessage();
            _videoConverter.VideoConverted+=_sendMessage.OnVideoConverted;
            _videoConverter.DoConvert();

            Console.Read();
        }
    }
    public class SendMessage
    {
        public void OnVideoConverted(object source,VideoEventArgs e)
        {
            System.Console.WriteLine("Mail is sended for video"+e.videoname);
        }
    }
}
