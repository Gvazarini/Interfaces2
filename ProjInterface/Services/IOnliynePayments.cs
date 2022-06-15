using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjInterface.Services
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double InterestFee(double amount, int months);
    }
}
