using OrderProcessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuisnessRule
{
    public partial class Form1 : Form
    {
        ConfirmationType EnumType;
        public Form1()
        {
            InitializeComponent();
        }

        private void CallFactory()
        {
            // Abstract Factory Call

            IConfirmationOrder ConfirmationService;
            ConfirmationFactory objConfirmationFactory = new ConfirmationFactory();
            ConfirmationService = objConfirmationFactory.GetConfirmationType(EnumType);
            lblOutPut.Text = ConfirmationService.ProcessOrder();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            CallFactory();
        }

        private void rdbOne_CheckedChanged(object sender, EventArgs e)
        {
            setCheckedState();
        }

        private void setCheckedState()
        {            
            if (rdbOne.Checked)
                EnumType = ConfirmationType.PHYSICAL_PAYMENT;
            else if (rdb2.Checked)
                EnumType = ConfirmationType.BOOK_PAYMENT;
            else if (rdb3.Checked)
                EnumType = ConfirmationType.MEMBERSHIP_ACTIVATION;
            else if (rdb4.Checked)
                EnumType = ConfirmationType.MEMBERSHIP_UPGRADE;
            else if (rdb6.Checked)
                EnumType = ConfirmationType.VIDEO_PAYMENT;

        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            setCheckedState();
        }

        private void rdb3_CheckedChanged(object sender, EventArgs e)
        {
            setCheckedState();
        }

        private void rdb4_CheckedChanged(object sender, EventArgs e)
        {
            setCheckedState();
        }

        private void rdb5_CheckedChanged(object sender, EventArgs e)
        {
            setCheckedState();
        }

        private void rdb6_CheckedChanged(object sender, EventArgs e)
        {
            setCheckedState();
        }

        private void rdb7_CheckedChanged(object sender, EventArgs e)
        {
            setCheckedState();
        }
    }
}
