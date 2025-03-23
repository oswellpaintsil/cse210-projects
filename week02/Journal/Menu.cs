public class Menu
{
       public void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        List<string>menuItems = new List<string> {"Write","Display","Load","Save","Quit"};
        foreach (string item in menuItems)
        {
                    int index = menuItems.IndexOf(item);
                    int id = index + 1;
                    Console.WriteLine($"{id}. {item}");
        }
        Console.Write("What would you like to do? ");
    }
}