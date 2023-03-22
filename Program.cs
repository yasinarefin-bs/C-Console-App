using System;

public class CardHolder
{
    String cardNum { get; set; }
    int pin { get; set; }
    String firstName { get; set; }
    String lastName { get; set; }

    double balance {get; set;}


    public CardHolder(String cardNum, int pin, String firstName, String lastName, double balance){
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;

        this.balance = balance;
    }



    public static void Main(String [] args){
        void printOptions(){
            Console.WriteLine("Hello");
            Console.WriteLine("Welcome to pingpong ATM machine");
            Console.WriteLine("Please choose option");
            Console.WriteLine("1) Deposit");
            Console.WriteLine("2) Withdraw");
            Console.WriteLine("3) SHow balance");
            Console.WriteLine("4) Exit");

        }


        void deposit(CardHolder currentUser){
            Console.WriteLine("How much money you want to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.balance += deposit;
            Console.WriteLine("Thank you for depositting.  Your current balance is " + currentUser.balance);
        }


        void withDraw(CardHolder currentUser){
            Console.WriteLine("How much money you want to withdraw?");
            double withdraw = Double.Parse(Console.ReadLine());

            if (currentUser.balance >= withdraw){
                Console.WriteLine(currentUser.balance+ " " + withdraw);
                currentUser.balance -= withdraw;
                Console.WriteLine("Thank you for withdrawing.  Your current balance is " + currentUser.balance);
            }else{

                Console.WriteLine("Cant withdraw the amount");
            }
            
        }

        void balance(CardHolder currentUser){
            Console.WriteLine("Current balance for user " + currentUser.firstName + " " + currentUser.balance);
        }

        List<CardHolder> cardHOlders = new List<CardHolder>();

        cardHOlders.Add(new CardHolder("1", 1, "A", "B", 10));
        cardHOlders.Add(new CardHolder("2", 2, "AB", "B", 20));
        cardHOlders.Add(new CardHolder("3", 3, "AC", "B", 10.64));
        cardHOlders.Add(new CardHolder("4", 4, "AD", "B", 5));
        cardHOlders.Add(new CardHolder("5", 5, "AZ", "B", 7));
        


        Console.WriteLine("Please insert ATM card");
        String card = "";

        CardHolder ch;


        while(true){

            try{
                card = Console.ReadLine();

                ch = cardHOlders.FirstOrDefault(a => a.cardNum == card);
                

                if(ch != null){
                    break;
                }else{
                    Console.WriteLine("Card not found");
                }

            }catch{
                Console.WriteLine("Card not found");
            }
        }


        Console.WriteLine("Please enter your pin");

        int userPin= 0;

        while(true){
            try{
                userPin = Int32.Parse(Console.ReadLine());
                if(ch.pin == userPin){
                    break;
                }else{
                    Console.WriteLine("Invalid pin");

                }
            }catch{
                Console.WriteLine("Invalid pin");
            }
        }

        Console.WriteLine("Welcome " + ch.firstName);

        int option = 0;

        
        do{
            printOptions();
            try{
                option =Int16.Parse(Console.ReadLine()); 
            }catch{
                Console.WriteLine("Invalid option");
                continue;
            }

            if(option == 1){
                 deposit(ch);
            }else if(option == 2){
                 withDraw(ch);
            }else if(option == 3){
                balance(ch);
            }
            
        }while(option != 4);
    }

}