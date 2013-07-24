#pragma warning disable 1591

using System;
using System.Collections.Generic;
using System.Text;

namespace Braintree
{
    public class TransactionOptionsRequest : Request
    {
        public Boolean? HoldForEscrow { get; set; }
        public Boolean? StoreInVault { get; set; }
        public Boolean? StoreInVaultOnSuccess { get; set; }
        public Boolean? AddBillingAddressToPaymentMethod { get; set; }
        public Boolean? StoreShippingAddressInVault { get; set; }
        public Boolean? SubmitForSettlement { get; set; }
        public String VenmoSdkSession { get; set; }

        public override String ToXml(String root)
        {
            return BuildRequest(root).ToXml();
        }

        public override String ToQueryString(String root)
        {
            return BuildRequest(root).ToQueryString();
        }

        protected virtual RequestBuilder BuildRequest(String root)
        {
            return new RequestBuilder(root).
                AddElement("hold-for-escrow", HoldForEscrow).
                AddElement("store-in-vault", StoreInVault).
                AddElement("store-in-vault-on-success", StoreInVaultOnSuccess).
                AddElement("add-billing-address-to-payment-method", AddBillingAddressToPaymentMethod).
                AddElement("store-shipping-address-in-vault", StoreShippingAddressInVault).
                AddElement("submit-for-settlement", SubmitForSettlement).
                AddElement("venmo-sdk-session", VenmoSdkSession);
        }
    }
}
