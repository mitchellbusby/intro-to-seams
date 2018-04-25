using System;
namespace IntroToSeams.Services
{
    public class CostingModel
    {
        public CostingModel()
        {
            
        }

        public void MakeChargeIfApplicable(int clientId, int numberOfSenders, string invoiceType) {
            InvoiceType = invoiceType;

            // Does some voodoo to determine the cost
            var cost = 0;

            if (InvoiceType == "foo")
            {
                cost = 10;
            }
            else if (InvoiceType == "bar") {
                cost = 20;
            }
            else if (InvoiceType == "FREE") {
                cost = 0;
            }
            else {
                cost = 35;
            }

            if (HasPaidUpForThisMonth) {
                cost = 0;
            }

            if (IsFoo) {
                TotalCostCurrently = cost;
            }
            else {
                TotalCostToEntityCurrently = cost;
            }

            if (cost == 0) {
                return;
            }


            // Charge client
            PayPalGateway.Instance.ChargeClient(numberOfSenders);

            // And save the invoice too
            InvoiceService.Instance.SaveInvoiceToClient(clientId, InvoiceType, cost);
        }

        /* public virtual bool ChargeClient(int numberOfSenders) {
            return PayPalGateway.Instance.ChargeClient(numberOfSenders);
        } */

        private bool IsFoo;
        private string InvoiceType;
        private bool HasPaidUpForThisMonth;
        private int TotalCostCurrently;
        private int TotalCostToEntityCurrently;
    }

    /* public class TestCostingModel : CostingModel {
        public override bool ChargeClient(int numberOfSenders) {
            return true;
        }
    } */
}
