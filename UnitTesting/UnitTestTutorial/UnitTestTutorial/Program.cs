bool IsRunning = true;

while(IsRunning == true)
{
    Console.WriteLine("Enter the TokenID");
    string TokenId = Console.ReadLine();
    Console.WriteLine("Enter the DoorID");
    int DoorId = Convert.ToInt32(Console.ReadLine());

    Logic.Validator.HasAccess(TokenId, DoorId);


}

//To Do: Fix input for the HasAccess method.