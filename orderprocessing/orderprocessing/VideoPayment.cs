using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class VideoPayment: IConfirmationOrder
    {
        public string ProcessOrder()
        {
            string text = "Option 5 Selected: Processing your Video Payment Learning to Ski....    DONE" + Environment.NewLine + Environment.NewLine; ;
            text = text + " ADDED FREE FIRST_AID VIDEO TO THE PACHKING SLIP" + Environment.NewLine;
            text = text + "PACKING SLIP NO: SHIP-" + DateTime.Now.ToShortDateString();
            return text;
        }
    }
}
