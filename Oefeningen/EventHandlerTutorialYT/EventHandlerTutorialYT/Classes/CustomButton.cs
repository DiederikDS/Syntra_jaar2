using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerTutorialYT.Classes
{
    internal class CustomButton
    {

        public EventHandler<MyCustomArguments> ClickEvent;

        public void OnClick()
        {
            MyCustomArguments myArgs = new MyCustomArguments();
            myArgs.Name = "Diederik";
            ClickEvent.Invoke(this, myArgs);
        }
    }
}
