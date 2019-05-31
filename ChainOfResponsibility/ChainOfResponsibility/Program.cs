using System;

namespace ChainOfResponsibilityx    
{
    class program

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {
            // Setup Chain of Responsibility

            Approver Waqas = new Director();
            Approver Azeem = new VicePresident();
            Approver Raheel = new President();

            Waqas.SetSuccessor(Azeem);
            Azeem.SetSuccessor(Raheel);

            // Generate and process purchase requests

            Purchase p = new Purchase(2034, 350.00, "Assets");
            Waqas.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Servers");
            Waqas.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Property");
            Waqas.ProcessRequest(p);

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>

    /// The 'Handler' abstract class

    /// </summary>

    abstract class Approver

    {
        protected Approver successor;

        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }

    /// <summary>

    /// The 'ConcreteHandler' class

    /// </summary>

    class Director : Approver

    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
            {
                Console.WriteLine("{0} approved request# {1} for buying {2} of amount {3}",
                  this.GetType().Name, purchase.Number, purchase.Purpose, purchase.Amount);
            }
            else if (successor != null)
            {
                successor.ProcessRequest(purchase);
            }
        }
    }

    /// <summary>

    /// The 'ConcreteHandler' class

    /// </summary>

    class VicePresident : Approver

    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 25000.0)
            {
                Console.WriteLine("{0} approved request# {1} for buying {2} of amount {3}",
                  this.GetType().Name, purchase.Number, purchase.Purpose, purchase.Amount);
            }
            else if (successor != null)
            {
                successor.ProcessRequest(purchase);
            }
        }
    }

    /// <summary>

    /// The 'ConcreteHandler' class

    /// </summary>

    class President : Approver

    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
            {
                Console.WriteLine("{0} approved request# {1} for buying {2} of amount {3}",
                  this.GetType().Name, purchase.Number, purchase.Purpose, purchase.Amount);
            }
            else

            {
                Console.WriteLine(
                  "Request# {0} requires an executive meeting!",
                  purchase.Number);
            }
        }
    }

    /// <summary>

    /// Class holding request details

    /// </summary>

    class Purchase

    {
        private int _number;
        private double _amount;
        private string _purpose;

        // Constructor

        public Purchase(int number, double amount, string purpose)
        {
            this._number = number;
            this._amount = amount;
            this._purpose = purpose;
        }

        // Gets or sets purchase number

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        // Gets or sets purchase amount

        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        // Gets or sets purchase purpose

        public string Purpose
        {
            get { return _purpose; }
            set { _purpose = value; }
        }
    }
}
