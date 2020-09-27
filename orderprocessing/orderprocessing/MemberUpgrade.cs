using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class MemberUpgrade: IConfirmationOrder
    {
        public string ProcessOrder()
        {
            string text = "Option 4 Selected: Processing your Membership Upgradation....    DONE" + Environment.NewLine + Environment.NewLine;
            text = text + "MEMBERSHIP UPGRADATION FOR THE USER TEST_USER IS SUCESSFULL." + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            text = text + "Email has been sent to he USER with the Activation code.";
            return text;
        }
    }
}
