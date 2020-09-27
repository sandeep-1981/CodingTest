using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class Commision: IConfirmationOrder
    {
        public string ProcessOrder()
        {
            string text = "Option 7 Selected: Processing your Commision....    DONE";

            return text;
        }
    }
}
