public class MenuManager
{
    public static bool loginMenuRunning = true;
    public static bool transactionMenuRunning = false;
    public static string userChoice = "";
    public static async Task MainMenu()
    {

        while (loginMenuRunning)
        {

            Console.Clear();
            LoginMenu.Execute();

            userChoice = Console.ReadLine()!;

            switch (userChoice)
            {
                case "1":
                    Console.Clear();
                    await AccountManager.CreateAccount();
                    break;
                case "2":
                    Console.Clear();
                    await AccountManager.Login();
                    break;
                case "3":
                    loginMenuRunning = false;
                    break;
            }
        }
    }

    public static async Task TransactionMenu()
    {

        while (transactionMenuRunning)
        {
            Console.Clear();
            Console.WriteLine("Financial Manager");
            Console.WriteLine("1. Add Transaction");
            Console.WriteLine("2. Remove Transaction");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Show Income by Period");
            Console.WriteLine("5. Show Expenses by Period");
            Console.WriteLine("6. Log out");
            Console.Write("Please choose an option: ");
            
            userChoice = Console.ReadLine()!;

            switch (userChoice)
            {
                case "1":

                    break;
                case "2":

                    break;
                case "3":

                    break;
                case "4":

                    break;
                case "5":

                    break;
                case "6":
                    transactionMenuRunning = false;
                    loginMenuRunning = true;
                    await MainMenu();
                    break;
            }
        }
    }
}