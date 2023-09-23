using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjectK.Day3
{
    internal class MediaContent
    {
        public void StartPlayingContent()
        {
            Console.WriteLine("Start");
        }
        public virtual void StopPlayingContent() { Console.WriteLine("stop"); }
         public virtual void PausePlayingContent() { Console.WriteLine("Pause"); }
        public virtual void  ContinuePlayingContent() { Console.WriteLine("Continue"); }
        public sealed override string ToString()
        {
            Console.WriteLine("Media ToString");
            return "OTP";
        }
    }

    internal class AudioContent : MediaContent {
        public override sealed void StopPlayingContent()
        {
            Console.WriteLine("Start from audiocontent");
        }

    }
    internal class VideoContent : AudioContent {
    }
    internal class MediaTester
    {
        
            public static void TestFive()
            {
               
            }
        }
    
}
