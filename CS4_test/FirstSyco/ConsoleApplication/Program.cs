using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Messaging;
using Shared;
using System.Timers;

namespace FirstSyco
{
    public class Program
    {

        private static string myMessageQueue = @".\private$\syco";
        private static MessageQueue messageQueue;
        public static Timer tmr = new Timer(5000);


        static void Main(string[] args)
        {
            messageQueue = new MessageQueue(@"FormatName:direct=os:" + myMessageQueue);
            messageQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(CoreMessage) });
            tmr.Elapsed += tmr_Elapsed;
            tmr.Start();
            Console.ReadKey();
        }

        static void tmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            CoreMessage msg = new CoreMessage() { menge = randNum(), beschreibung = randString(), bezeichnung = randString() };
            messageQueue.Send(msg);
        }

        public static int randNum()
        {
            Random rnd = new Random();
            return rnd.Next(1, 100);
        }


        //  public static string path;
        public static string randString()
        {
            string path = Path.GetRandomFileName();
            path = path.Replace(".", "");
            return path.ToString().Substring(0, 9);

            //path = ""; 
            //string alpha = "abcdefghIJKLMNopqrstUVWXyz";
            //char [] pathArr = alpha.ToArray();
            //Random ran = new Random();
            //for (int i = 0; i < 10; i++)
            //{                
            //    int j = ran.Next(0, pathArr.Length-1);
            //    path += pathArr[j];                 
            //} return path;
        }


    }
}
