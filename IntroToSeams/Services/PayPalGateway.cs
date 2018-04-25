using System;
using System.Threading;

namespace IntroToSeams.Services
{
    public class PayPalGateway
    {
        private static PayPalGateway instance = null;

        public PayPalGateway()
        {
        }

        public static PayPalGateway Instance {
            get {
                if (instance == null) {
                    instance = new PayPalGateway();
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
