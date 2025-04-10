public class Menu
{

    public void MenuOptions()
        {
            List<string> activities = new List<string>();
            activities.Add("breathing");
            activities.Add("reflecting");
            activities.Add("listing");
            activities.Add("Quit");
            
            Console.WriteLine("Menu Options:");
            foreach (string activity in activities)
            {
                if (activity != "Quit")
                {
                    Console.WriteLine($"{activities.IndexOf(activity) + 1,3}. Start {activity} activity");
                    
                }
                else
                {
                    Console.WriteLine($"{activities.IndexOf(activity) + 1,3}. {activity}");
                }
            }
            Console.Write("Select a choice from the menu: ");
           
        }

        public int GetResponse()
        {
            int response = int.Parse(Console.ReadLine());
            return response;
        }

}