using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class BookPayment:IConfirmationOrder
    {
        public string ProcessOrder()
        {
            string text = "Option 2 Selected: Generating duplicate packing slip for the royalty department....    DONE" + Environment.NewLine + Environment.NewLine;
            text = text + "DUPLICATE PACKING SLIP NO: SHIP-" + DateTime.Now.ToShortDateString() + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;

            text = text + "Genearated comission payment to the agent";
            return text;
        }
    }
}


