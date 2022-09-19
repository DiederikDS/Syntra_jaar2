using ExceptieOefening3_Door.Classes;

Door door = new();

Console.WriteLine("Case 1:");

try
{
    door.IsLocked = true;
    door.IsOpen = false;
    door.OpenDoor();
    Console.WriteLine("The door is opened");
}
catch (Exception e)
{

    Console.WriteLine(e.Message);
}

Console.WriteLine("------------------------------------------------------------------------------");
Console.WriteLine("Case 2:");

try
{
    door.IsLocked = false;
    door.IsOpen = true;
    door.LockDoor();
    Console.WriteLine("The door is Locked");
}
catch (Exception e)
{

    Console.WriteLine(e.Message);
}

Console.WriteLine("------------------------------------------------------------------------------");
Console.WriteLine("Case 3:");

try
{
    door.IsLocked = false;
    door.IsOpen = true;
    door.OpenDoor();
    Console.WriteLine("The door is Opened");
}
catch (Exception e)
{

    Console.WriteLine(e.Message);
}

Console.WriteLine("------------------------------------------------------------------------------");
Console.WriteLine("Case 4:");

try
{
    door.IsLocked = true;
    door.IsOpen = false;
    door.LockDoor();
    Console.WriteLine("The door is Locked");
}
catch (Exception e)
{

    Console.WriteLine(e.Message);
}

Console.WriteLine("------------------------------------------------------------------------------");