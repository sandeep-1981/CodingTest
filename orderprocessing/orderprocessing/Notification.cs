using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class Notification: IConfirmationOrder
    {
        public string ProcessOrder()
        {
            string text = "Option 5 Selected: Notifying the Owner....    DONE";
            text = text + "EMAIL SENT TO THE USER TEST_USER WITH THE ACTIVATION CODE.";
            return text;
        }
    }
}
