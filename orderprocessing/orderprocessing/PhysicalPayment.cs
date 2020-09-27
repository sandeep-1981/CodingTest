using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class PhysicalPayment : IConfirmationOrder
    {
        public string ProcessOrder()
        {
            string text = "Option 1 Selected: Generate a packing slip for shipping...." + Environment.NewLine + Environment.NewLine;
            text = text + "PACKING SLIP NO: SHIP-" + DateTime.Now.ToShortDateString() + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;

            text = text + "Genearated comission payment to the agent";
            return text;

        }
    }
}
