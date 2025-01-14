
void WriteSomething()
{
    Console.WriteLine("Write");
}

WriteSomething();

void WriteSomethingSpecific(string myString)
{
    Console.WriteLine("My string is " + myString);
}

int AddTwoValues(int value1 ,int value2)
{
    int result = value1 + value2;   
    return result;

}int SubtractTwoValues(int value1 ,int value2)
{
    int result =(value1 - value2);   
    return result;

}

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

int myResult = AddTwoValues(num1, num2);
int myResult1 = SubtractTwoValues(num1, num2);

WriteSomethingSpecific("The result is " + myResult);

Console.ReadKey();