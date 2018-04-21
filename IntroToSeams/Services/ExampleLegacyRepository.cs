using System;
using System.Threading;

namespace IntroToSeams.Services
{
    public class ExampleRepository
    {
        private static ExampleRepository instance = null;

        public ExampleRepository()
        {
        }

        public static ExampleRepository Instance {
            get {
                if (instance == null) {
                    instance = new ExampleRepository();
                }

                return instance;
            }
        }

        public bool ChargeClient(int numberOfSenders)
        {
            Thread.Sleep(5000);
            return true;
        }
    }
}
