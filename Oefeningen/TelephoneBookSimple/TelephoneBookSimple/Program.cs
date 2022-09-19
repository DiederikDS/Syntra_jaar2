using TelephoneBookSimple.Classes;

//Setup and adding data
TelephoneBook Network = new TelephoneBook();

Phone phone1 = new Phone("0491436501");
Phone phone2 = new Phone("0491436502");
Phone phone3 = new Phone("0491436503");

Network.Phones.Add(phone1);
Network.Phones.Add(phone2);
Network.Phones.Add(phone3);

Network.CallPhone(0);

Network.SendMessage(0, "Hi, this is Diederik letting you know I completed the exercise");