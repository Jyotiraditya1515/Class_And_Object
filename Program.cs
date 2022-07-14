// See https://aka.ms/new-console-template for more information
using Class_And_Object;
//Student s1 = new Student(1, "Ram", "Kumar", 50);
//Console.WriteLine(s1);
//Employee e1 = new Employee(2, "Elon Musk", 200000,Department.Production);
//Console.WriteLine(e1);
Employee e2=new Employee();

Date d1 = new Date(01, 01, 2022);
Employee[] arr = new Employee[2];
arr[0] = new Employee(1,"Bill Gates",100000,Department.IT,d1);
arr[1] = new Employee(2, "Elon Musk", 200000, Department.Production,d1);

foreach(Employee e in arr)
{
    Console.WriteLine(e+"\n");
}

Manager m1 = new Manager();
Manager m2 = new Manager(2000, 500, 2, "Bill", 10000, Department.IT, d1);
Console.WriteLine(m1);
Console.WriteLine(m2);
e2.GrossSal();
m1.GrossSal();