using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class ConfirmationFactory
    {
        public IConfirmationOrder GetConfirmationType(Enum confirmationType)
        {
            IConfirmationOrder iProduct = null;
            ConfirmationType EnumType = (ConfirmationType)confirmationType;

            switch (EnumType)
            {
                case ConfirmationType.PHYSICAL_PAYMENT:
                    iProduct = new PhysicalPayment();
                    break;
                case ConfirmationType.BOOK_PAYMENT:
                    iProduct = new BookPayment();
                    break;
                case ConfirmationType.MEMBERSHIP_ACTIVATION:
                    iProduct = new MemberActivation();
                    break;
                case ConfirmationType.MEMBERSHIP_UPGRADE:
                    iProduct = new MemberUpgrade();
                    break;
                case ConfirmationType.NOTIFICATION:
                    iProduct = new Notification();
                    break;
                case ConfirmationType.VIDEO_PAYMENT:
                    iProduct = new VideoPayment();
                    break;
                case ConfirmationType.COMMISION:
                    iProduct = new Commision();
                    break;
               
                default:
                    break;
            }
            return iProduct;
        }
    }
}
