using Braintree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment_Application.Service
{
    public interface IBraintreeService
    {
        IBraintreeGateway CreateGateway();
        IBraintreeGateway GetGateway();
    }
}
