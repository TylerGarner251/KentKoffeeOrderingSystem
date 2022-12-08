//Variable
using System.Runtime.CompilerServices;
string CoffeeVar = "";
string coffeeDisplay = "";
string DiscountDisplay = "";
string syrup = "";
int bulk;
Double Calculation;
string Total = "";
string reorder = "";
void CostDisplay() //Displays the Cost and Information
{
    Console.Clear();
    Console.WriteLine("Coffee: " + coffeeDisplay + "\nSyrup: " + syrup + "\nVoloume: " + bulk + "\nDiscount: " + DiscountDisplay + "\nTotal: " + Total + "\nWould you like to re-order? | Please type 'y' for yes and 'n' for No");
    reorder = Console.ReadLine().ToLower();
    if (reorder == "y")
    {
        Console.Clear();
        KentKoffee();
    }
    else
    {
        System.Environment.Exit(0);
    }
}
void KentKoffee() //Runs the whole programme
{

    Console.WriteLine("Welcome to Kent Koffee" + "\nPlease Select what coffee you would like by typing corresponding letter" + "\nL: Latte | C: Cappuccino | E: Espresso");
    CoffeeVar = Console.ReadLine();


    switch (CoffeeVar.ToUpper())
    {
        #region Latte
        case ("L"):
            Console.Clear();
            Console.WriteLine("You have Chosen Latte | £3.85" + "\nWould you like Syrup Price | £1.00 | Please type 'y' for yes and 'n' for No");
            syrup = Console.ReadLine().ToLower();
            switch (syrup)
            {
                case ("y"):
                    Console.WriteLine("How many would you like to order?");
                    bulk = int.Parse(Console.ReadLine());
                    if (bulk >= 5 && bulk <= 7)
                    {
                        coffeeDisplay = "Latte";
                        DiscountDisplay = "5%";
                        Calculation = (3.85 + 1.00) * 0.95;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    else if (bulk >= 8 && bulk <= 14)
                    {
                        coffeeDisplay = "Latte";
                        DiscountDisplay = "10%";
                        Calculation = (3.85 + 1.00) * 0.90;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    else if (bulk >= 15)
                    {
                        coffeeDisplay = "Latte";
                        DiscountDisplay = "15%";
                        Calculation = (3.85 + 1.00) * 0.85;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    else
                    {
                        coffeeDisplay = "Latte";
                        DiscountDisplay = "0%";
                        Calculation = 3.85 + 1.00;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    break;
                case ("n"):
                    Console.WriteLine("How many would you like to order?");
                    bulk = int.Parse(Console.ReadLine());
                    if (bulk >= 5 && bulk <= 7)
                    {
                        coffeeDisplay = "Latte";
                        DiscountDisplay = "5%";
                        Calculation = 3.85 * 0.95;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    else if (bulk >= 8 && bulk <= 14)
                    {
                        coffeeDisplay = "Latte";
                        DiscountDisplay = "10%";
                        Calculation = 3.85 * 0.90;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    else if (bulk >= 15)
                    {
                        coffeeDisplay = "Latte";
                        DiscountDisplay = "15%";
                        Calculation = 3.85 * 0.85;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    else
                    {
                        coffeeDisplay = "Latte";
                        DiscountDisplay = "0%";
                        Calculation = 3.85;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    break;
            }
            break;
        #endregion
        #region Cappuccino
        case ("C"):
            Console.Clear();
            Console.WriteLine("You have Chosen Cappuccino | £3.85" + "\nWould you like Syrup Price | £1.00 | Please type 'y' for yes and 'n' for No");
            syrup = Console.ReadLine().ToLower();
            switch (syrup)
            {
                case ("y"):
                    Console.WriteLine("How many would you like to order?");
                    bulk = int.Parse(Console.ReadLine());
                    if (bulk >= 5 && bulk <= 7)
                    {
                        coffeeDisplay = "Cappuccino";
                        DiscountDisplay = "5%";
                        Calculation = (3.85 + 1.00) * 0.95;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    else if (bulk >= 8 && bulk <= 14)
                    {
                        coffeeDisplay = "Cappuccino";
                        DiscountDisplay = "10%";
                        Calculation = (3.85 + 1.00) * 0.90;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    else if (bulk >= 15)
                    {
                        coffeeDisplay = "Cappuccino";
                        DiscountDisplay = "15%";
                        Calculation = (3.85 + 1.00) * 0.85;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    else
                    {
                        coffeeDisplay = "Cappuccino";
                        DiscountDisplay = "0%";
                        Calculation = 3.85 + 1.00;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    break;
                case ("n"):
                    Console.WriteLine("How many would you like to order?");
                    bulk = int.Parse(Console.ReadLine());
                    if (bulk >= 5 && bulk <= 7)
                    {
                        coffeeDisplay = "Cappuccino";
                        DiscountDisplay = "5%";
                        Calculation = 3.85 * 0.95;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    else if (bulk >= 8 && bulk <= 14)
                    {
                        coffeeDisplay = "Cappuccino";
                        DiscountDisplay = "10%";
                        Calculation = 3.85 * 0.90;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    else if (bulk >= 15)
                    {
                        coffeeDisplay = "Cappuccino";
                        DiscountDisplay = "15%";
                        Calculation = 3.85 * 0.85;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    else
                    {
                        coffeeDisplay = "Cappuccino";
                        DiscountDisplay = "0%";
                        Calculation = 3.85;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    break;
            }
            break;
        #endregion
        #region Espresso
        case ("E"):
            Console.Clear();
            Console.WriteLine("You have Chosen Espresso | £3.35" + "\nWould you like Syrup Price | £0.80 | Please type 'y' for yes and 'n' for No");
            syrup = Console.ReadLine().ToLower();
            switch (syrup)
            {
                case ("y"):
                    Console.WriteLine("How many would you like to order?");
                    bulk = int.Parse(Console.ReadLine());
                    if (bulk >= 5 && bulk <= 7)
                    {
                        coffeeDisplay = "Espresso";
                        DiscountDisplay = "5%";
                        Calculation = (3.35 + 0.80) * 0.95;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    else if (bulk >= 8 && bulk <= 14)
                    {
                        coffeeDisplay = "Espresso";
                        DiscountDisplay = "10%";
                        Calculation = (3.35 + 0.80) * 0.90;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    else if (bulk >= 15)
                    {
                        coffeeDisplay = "Espresso";
                        DiscountDisplay = "15%";
                        Calculation = (3.35 + 0.80) * 0.85;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    else
                    {
                        coffeeDisplay = "Espresso";
                        DiscountDisplay = "0%";
                        Calculation = 3.35 + 0.80;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    break;
                case ("n"):
                    Console.WriteLine("How many would you like to order?");
                    bulk = int.Parse(Console.ReadLine());
                    if (bulk >= 5 && bulk <= 7)
                    {
                        coffeeDisplay = "Espresso";
                        DiscountDisplay = "5%";
                        Calculation = 3.35 * 0.95;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    else if (bulk >= 8 && bulk <= 14)
                    {
                        coffeeDisplay = "Espresso";
                        DiscountDisplay = "10%";
                        Calculation = 3.35 * 0.90;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    else if (bulk >= 15)
                    {
                        coffeeDisplay = "Espresso";
                        DiscountDisplay = "15%";
                        Calculation = 3.35 * 0.85;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    else
                    {
                        coffeeDisplay = "Espresso";
                        DiscountDisplay = "0%";
                        Calculation = 3.35;
                        Total = Calculation.ToString("#.##");
                        CostDisplay();
                    }
                    break;
            }
            break;
            #endregion
    }
}
KentKoffee();