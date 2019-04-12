using System;

namespace Event
{

    class Program
    {
        static void Main(string[] args)
        {
         
         
            
            VideoConverter _videoConverter=new VideoConverter(new Video("Jomanji"),new VideoEventArgs());
            SendMessage _sendMessage=new SendMessage();
            _videoConverter.VideoConverted+=_sendMessage.SendMail;
            _videoConverter.VideoConverted+=_sendMessage.Sendsms;
            _videoConverter.DoConvert();

            Console.Read();
        }
    }
    public class SendMessage
    {
        public void SendMail(object source,VideoEventArgs e)
        {
            System.Console.WriteLine("Mail is sended for video"+e.videoname);
        }
           public void Sendsms(object source,VideoEventArgs e)
        {
            System.Console.WriteLine("SMS is sended for video"+e.videoname);
        }
    }
}
