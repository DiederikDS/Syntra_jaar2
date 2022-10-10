using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoorbeelExamen
{
    public partial class PhoneWindow : Form
    {
        Phone _phone;
        PhoneNetwork<Phone> _phoneNetwork;
        int _tickCounter;

        public PhoneWindow(Phone selectedPhone, PhoneNetwork network)
        {
            InitializeComponent();
            _phone = selectedPhone;
            _phoneNetwork = network;
            _phone.CallReceived += phone.CallReceived;
        }

        private void phone_CallReceived(object? sender, EventArgs e)
        {
            _tickCounter = 0;
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            
            if (_tickCounter % 5 == 0)
            {
                this.BackColor = Color.RebeccaPurple;
            }
            else
            {
                this.BackColor= DefaultBackColor;
            }

            _tickCounter++;

            if (_tickCounter == 25)
            {
                ((System.Windows.Forms.Timer)sender).Stop();
            }
        }

        private void Btn_Call_Click(object sender, EventArgs e)
        {
            var number = TxtB_PhoneNumber.Text;
            _phoneNetwork.CallPhone(number);
        }
    }
}
