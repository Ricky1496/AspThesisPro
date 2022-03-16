using System;

namespace AspThesisPro.Services
{
    public class MyEmailSenderException
        :ApplicationException
    {
        private const string StandaradERRORMESSAGE = "Something went wrong while sending the email.";

        public MyEmailSenderException()
            :base(StandaradERRORMESSAGE)
        {
        }

        public MyEmailSenderException(string message)
            :base(message)
        {
        }

        public MyEmailSenderException(string message, Exception exception)
            :base(message, exception)
        {
        }

    }
}
