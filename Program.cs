namespace classesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //carr audi = new carr("A3", "Audi", false);
            //carr bmw = new carr("M5", "BMW", true);

            //Console.WriteLine("Brand is " + audi.Brand);
            //Console.WriteLine("Brand is " + bmw.Brand);

            //Horse good = new Horse("grey", "australia",true);
            //Horse bad = new Horse("black", "france",false);
            Customer earl = new Customer("Earl");
            Customer frank = new Customer("Frank", "Mainstreet 1", "5556670134");
            //Console.WriteLine("Name of customer is " + earl.Name);

            //// Default customer 
            Customer myCustomer = new Customer();
            myCustomer.SetDetails("Frank", "Mainstreet 1", "5556670134");
            Console.WriteLine("My customer is: " + myCustomer.Name + " and he lives in " + myCustomer.Address);
            Console.WriteLine("My customer is: " + earl.Name + " and he lives in " + earl.Address);
            
            Customer Customer = new Customer();
            Customer.SetDetails("John", "Mainstreet");

            //Console.WriteLine("Details about customer " + myCustomer.Name
            //carr myAudi = new carr("A3", "Audi", false);

            //carr myBmw = new carr("M5", "BMW", true);

            //myAudi.Drive();
            //myBmw.Drive();

            Console.WriteLine(AddNum(15, 25));
            Console.WriteLine(AddNum(firstNum:23,secondNum:25));

            Console.ReadKey();
        }
        
        static int AddNum (int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
