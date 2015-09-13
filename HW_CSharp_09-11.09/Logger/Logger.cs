using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW_CSharp_09_11._09.Logger
{
    public sealed class Logger
    {
        public enum MessageType
        {
            Info,
            Warn,
            Error
        }

        private static volatile Logger instance;
        private static object syncRoot = new Object();

        private Logger() { }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Logger();
                    }
                }

                return instance;
            }
        }

        public void Write(Exception e, MessageType type = MessageType.Info)
        {
            
        }

        public void Write(Exception e, string message, MessageType type = MessageType.Info)
        {

        }

        public void Write(string Message, MessageType type = MessageType.Info)
        {

        }
    }
}