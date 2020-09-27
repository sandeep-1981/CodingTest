using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class MemberActivation: IConfirmationOrder
    {
        public string ProcessOrder()
        {
            string text = "Option 3 Selected: Processing your Membership Activation....    DONE" + Environment.NewLine + Environment.NewLine; 
            text = text + "MEMBERSHIP -" + "TEST_USER ACTIVATED." + Environment.NewLine + Environment.NewLine +Environment.NewLine + Environment.NewLine;
            text = text + "Email has been sent to he USER with the Activation code.";
            return text;
        }
    }
}
