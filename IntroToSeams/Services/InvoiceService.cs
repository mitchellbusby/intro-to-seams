using System;
using System.Threading;

namespace IntroToSeams.Services
{
    public class InvoiceService
    {
        private static InvoiceService instance = null;
        public InvoiceService()
        {
            
        }

        public static InvoiceService Instance {
            get {
                if (instance == null) {
                    instance = new InvoiceService();
                }

                return instance;
            }
        }

        public void SaveInvoiceToClient(int clientId, string invoiceType, int cost) {
            Thread.Sleep(100);
        }
    }
}
