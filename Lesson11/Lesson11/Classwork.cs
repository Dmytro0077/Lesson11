//namespace Classwork
//{ 
//class Example
//{
//    int _num;

//    public void Set(int num)
//    {
//        _num = num;
//    }

//    public int Get()
//    {
//        return _num;
//    }

//        public int MyProperty { get; set; }
//        public int MyProperty { get; set; }
//    }
//public void Main()
// {
//        int f = 0;
//Console.WriteLine("Please, enter the integer number:");
//example.Set(int.Parse(Console.ReadLine()));
//Console.WriteLine("You enter:");
//Console.WriteLine(example.Get());
//}
// }


class Person
{
    int age = 1;
    public int Age
    {
        set
        {
            if (value < 1 || value > 120)
                Console.WriteLine("Вік має бути в діапазоні від 1 до 120");
            else
                age = value;
        }
        get { return age; }
    }
}


Person den = new Person();
den.Age = -23;
Console.WriteLine(den.Age);