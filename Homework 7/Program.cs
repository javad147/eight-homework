using HomeWork_7;

//1.Method array qebul edir, arrayin icerisindeki tek ededlerin cemini tapin.

//CustomMath customMath = new CustomMath();
//int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
//int sum = customMath.SumUniqueElements(array);
//Console.WriteLine("Tek ededlerin Cemi : " + sum);
//Console.ReadLine();


//2.Methoda gelen ededin tek ve ya cut olub olmamasini gosterin.

//CustomMath customMath = new CustomMath();

//int numb = 7;
//bool result = CustomMath.IsEven(numb);
//if (result)
//{
//    Console.WriteLine("Eded Cutdur");

//}
//else 
//{
//    Console.WriteLine("Eded Tekdir");

//}


//3.Methoda gelen arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.

//CustomMath customMath = new CustomMath();
//int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
//int sum = customMath.SquareOfSum(array);
//Console.WriteLine("Cut ededlerin Ceminin Kvadrati : " + sum);
//Console.ReadLine();


//4 Methoda n ededi gelir, 1-den n ededine qeder olan ededlerin hasilini tapin.

//CustomMath  customMath = new CustomMath();
//int n = 5;
//int product = CustomMath.product(n);
//{
//    Console.WriteLine(product);

//}


//1.Yashi methoda parametr kimi gelen yashdan boyuk olan employee -lerin  siyahisini qaytaran method.


Employee employee1 = new Employee()
{
    id = 1,
    name = "Javad",
    surname = "Bakirli",
    address = "Binagadi",
    email = "javad.bakirli@gmail.com",
    age = 32,
};

Employee employee2 = new Employee()
{
    id = 2,
    name = "Kainat",
    surname = "Qulizada",
    address = "Yasamal",
    email = "kainat.gulizada@gmail.com",
    age = 38,
};
Employee employee3 = new Employee()
{
    id = 3,
    name = "Yunis",
    surname = "Aliyev",
    address = "Ahmadli",
    email = "yunis.aliyev@gmail.com",
    age = 34,
};
Employee employee4 = new Employee()
{
    id = 4,
    name = "Qoshqar",
    surname = "Jafarov",
    address = "Kubinka",
    email = "qoshqar.jafarov@gmail.com",
    age = 36,
};
Employee employee5 = new Employee()
{
    id = 5,
    name = "Ali",
    surname = "Aliyev",
    address = "Sovetski",
    email = "ali.aliyev@gmail.com",
    age = 29,
};

Employee[] employees = {employee1,employee2,employee3,employee4,employee5};

Employee.FindByNumber(employees, 30);
Console.ReadLine();

int count = Employee.CountEmployeesInAgeRange(employees, 20, 30);
Console.WriteLine($"20 ve 30 yaş arasında olan işçilerin sayı: {count}");
Console.ReadLine();

int Sum = Employee.SumOfAge(employees);
Console.WriteLine(Sum);
Console.ReadLine();

string searchLetter = "ja";
Employee.FindEmailsByFirstLetter(employees, searchLetter);