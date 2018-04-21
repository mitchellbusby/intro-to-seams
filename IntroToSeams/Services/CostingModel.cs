using System;
namespace IntroToSeams.Services
{
    public class CostingModel
    {
        public CostingModel()
        {
            
        }

        public void MakeChargeIfApplicable(int clientId, int numberOfSenders) {
            // Does some voodoo
            // TODO: generate voodoo


            ExampleRepository.Instance.ChargeClient(numberOfSenders);
        }

        public bool ChargeClient(int numberOfSenders) {
            return ExampleRepository.Instance.ChargeClient(numberOfSenders);
        }
    }

    public class TestCostingModel : CostingModel {
        public override bool ChargeClient(int numberOfSenders) {
            
        }
    }
}
