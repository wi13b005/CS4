using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MessageGUI.Communication
{
    public class MessageQueueReader
    {
        private string myMessageQueue = @".\private$\syco";
        private MessageQueue messageQueue;
        private Informer informer;

        public MessageQueueReader(Informer informer)
        {
            messageQueue = new MessageQueue(@"FormatName:direct=os:" + myMessageQueue);
            messageQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(CoreMessage) });
            Thread thr = new Thread(() =>
            {
                while (true)
                {
                    Message message = messageQueue.Receive();
                    informer((CoreMessage)message.Body);

                }
            });
            thr.Start();
        }




    }
}


