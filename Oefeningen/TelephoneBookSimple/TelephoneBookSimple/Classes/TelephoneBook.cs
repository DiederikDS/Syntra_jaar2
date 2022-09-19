using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneBookSimple.Classes
{
    internal class TelephoneBook
    {
        public List<Phone> Phones { get; set; } = new List<Phone>();

        //Delegate which defines the methode(s) that are refered to
        public delegate void CallPhoneEventHandler(object source, EventArgs args);
        public delegate void MessagePhoneEventHandler(object source, MessageArgs args);

        //Event based on the definiton of the delegate
        public event CallPhoneEventHandler PhoneCalled;
        public event MessagePhoneEventHandler MessageSent;

        //Method to raise the event (notify its subscribers)
        protected virtual void OnPhoneCalled()
        {
            PhoneCalled?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnMessageSent(string message)
        {
            MessageSent?.Invoke(this, new MessageArgs( message));
        }

        public void CallPhone(int number)
        {
            this.PhoneCalled += Phones[number].OnCalled;
            OnPhoneCalled();
        }

        public void SendMessage(int number, string message)
        {
            this.MessageSent += Phones[number].OnMessageSent;
            OnMessageSent(message);
        }
    }
}
