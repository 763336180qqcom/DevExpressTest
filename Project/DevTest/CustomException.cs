using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace DevTest
{
    [Serializable]
    internal class CustomException :ApplicationException
    {
        public CustomException()
        {
            
        }
        public CustomException(string message)
            : base(message)
        {
        }
        public override string Message
        {
            get
            {
                return base.Message + "！";
            }
        }
        public CustomException(string message, Exception innerException)
            : base(message, innerException)
        {
            
        }
        protected CustomException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            
        }
    }
}