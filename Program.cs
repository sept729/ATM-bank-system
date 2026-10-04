namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double deposit = 0;
            double withdraw = 0;
            double balance = 10000;
            int accountNumber = 0;
            
           Console.WriteLine($"Create an account:");
           string createAccount = Console.ReadLine();
            Console.WriteLine($"Account created successfully. Your account number is:{accountNumber}");
            while(true)
            {
                Random random = new Random();
                int randomaccountNumber = random.Next(100000, 999999);
                Console.WriteLine(randomaccountNumber);
                accountNumber = randomaccountNumber;
                break;
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter your account number to login: ");
                int enteredAccountNumber = Convert.ToInt32(Console.ReadLine());
                if (enteredAccountNumber == accountNumber)
                {
                    Console.WriteLine($"Login successful.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Invalid account number. Please try again.");
                    if (i == 2)
                    {
                        Console.WriteLine($"You have exceeded the maximum number of login attempts. Exiting...");
                        return;
                    }
                }
            }
            List<string> transactionHistory = new List<string>();
            while (true)
            {
               Console.WriteLine($"Enter your PIN to login: ");
                int enteredPin = Convert.ToInt32(Console.ReadLine());
                if(enteredPin == 1234)
                {
                    Console.WriteLine($"Login successful.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Invalid PIN. Please try again.");
                }

            }
            while (true)
            {
                Console.WriteLine($"select an option: 1. Deposit 2. Withdraw 3. Check Balance 4. Transaction History 5. Exit");
                string option = Console.ReadLine();
                if (option != null)
                {
                    switch (option)
                    {
                        case "1":
                            Console.WriteLine("Enter amount to deposit: ");
                            deposit = Convert.ToDouble(Console.ReadLine());
                            balance += deposit;
                            transactionHistory.Add($"Deposited: {deposit}");
                            Console.WriteLine($"New balance: {balance}");
                            break;
                        case "2":
                            Console.WriteLine("Enter amount to withdraw: ");
                            withdraw = Convert.ToDouble(Console.ReadLine());
                            if (withdraw > balance)
                            {
                                Console.WriteLine("Insufficient balance.");
                            }
                            else
                            {
                                balance -= withdraw;
                                transactionHistory.Add($"Withdrew: {withdraw}");
                                Console.WriteLine($"New balance: {balance}");
                            }
                            break;
                        case "3":
                            Console.WriteLine($"Current balance: {balance}");
                            break;
                        case "4":
                            Console.WriteLine("Transaction History:");
                            foreach (var transaction in transactionHistory)
                            {
                                Console.WriteLine(transaction);
                            }
                            break;
                        case "5":
                            Console.WriteLine("Exiting...");
                            return;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
            }
        }
    }
}
