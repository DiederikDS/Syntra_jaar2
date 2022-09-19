using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptieOefening3_Door.Classes
{
    class Door
    {
        public Door()
        {

        }

        public bool IsLocked { get; set; }

        public bool IsOpen { get; set; }

        public void LockDoor()
        {
            if (IsOpen)
            {
                throw new DoorIsOpenException("The door can not be locked, when it is open.");
            }

            if (IsLocked)
            {
                throw new DoorIsLockedException("The door is already locked.");
            }

            IsLocked = true;
        }

        public void UnlockDoor()
        {
            //if (IsOpen)
            //{
            //    throw new DoorIsOpenException("Door cannot be unlocked while it is open");
            //}

            if (!IsLocked)
            {
                throw new DoorIsUnlockedException("The door is already unlocked.");
            }

            IsLocked = false;
        }

        public void OpenDoor()
        {
            if (IsLocked)
            {
                throw new DoorIsLockedException("The door cannot open, when it is locked.");
            }

            if (IsOpen)
            {
                throw new DoorIsOpenException("The door is already open.");
            }

            IsOpen = true;
        }

        public void CloseDoor()
        {

        }


    }
}
