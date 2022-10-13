namespace ShoppingCartLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // use double to add ints. to use dictionary you must "= new"
            Dictionary<string, double> itemsToPrices = new Dictionary<string, double>();
​
            itemsToPrices.Add("now and laters", .99);
            itemsToPrices.Add("eggs", 3.99);
            itemsToPrices.Add("gum", 1.99);
            itemsToPrices.Add("sausage", 5.99);
            itemsToPrices.Add("Chicken", 14.99);
            itemsToPrices.Add("Rice", 2.99);
            itemsToPrices.Add("Steak", 25.99);
            itemsToPrices.Add("chips", 4.99)
​
            List<string> cart = new List<string>();

            //get comfortable with bool/while goOn​ its used frequently 
            bool goOn = true;
            while (goOn == true)
            {
                Console.WriteLine("What would you like? Enter either the name of the item or select the item by number");
​
                int menuNum = -1;
                foreach (string key in itemsToPrices.Keys)
                {
                    Console.WriteLine(menuNum + ": " + key + " $" + itemsToPrices[key]);
                    menuNum++;
                }
​
                bool inputNum = false;
                string input = Console.ReadLine();
                int index = -1;
              
                try
                {
                    
                    index = int.Parse(input);
                    inputNum = true;
                }
                    //not sure what the formatexception e does 
                catch (FormatException e)
                {
                 
                    inputNum = false;
                }
                if (inputNum == true)
                {
                    if (index >= 0 && index < itemsToPrices.Keys.Count)
                    {
                        string item = itemsToPrices.Keys.ToList()[index];
                        cart.Add(item);
                    }
                }
                else
                {
                    if (input) // not sure what to put here
                    {
                       
                        cart.Add(input);
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry {input} is not available, lets try that again!");
                    }
                }
                goOn = goAgain();
            }
​
            //I am not sure how to display cart
        }
​
​
        public static bool goAgain()
        {
            Console.WriteLine("Would you like to add another item to your cart? Y/N");
​
            string input = Console.ReadLine().Trim().ToLower();
​
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Hey I didn't understand that lets try again");
                return goAgain();
            }
        }
    }
}