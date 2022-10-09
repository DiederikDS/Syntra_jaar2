using EventHandlerTutorialYT.Classes;

void KeyPressed()
{
    CustomButton button = new CustomButton();
    button.ClickEvent += (s, args) => { Console.WriteLine($"You clicked a button {args.Name}"); };
    button.OnClick();
}

Console.WriteLine("Press A to simulate a button click");
var key = Console.ReadLine();
if (key == "a")
{
    KeyPressed();
}