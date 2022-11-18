using System;

namespace AddressBook2
{
    class program
{
    public static void Main(string[] args)
    {
        List<Person> listpersonInCity = new List<Person>();
        AddRecords(listpersonInCity);

        doSetDemo();
    }

    private static void AddRecords(List<Person> listpersonInCity)
    {
        listpersonInCity.Add(new Person("Chetan Rathod", "Noida Sector 12", "Noida", "Delhi", " 234357", "9762733729", "chetan@gmail.com"));
        listpersonInCity.Add(new Person("vijay Raj", "Noida Sector 13", "Noida", "Delhi", " 234357", "9754794287", "vijay@gmail.com"));
        listpersonInCity.Add(new Person("Kishan Singh", "Noida Sector 14", "Noida", "Delhi", " 234357", "9762797462", "kishan@gmail.com"));
        listpersonInCity.Add(new Person("Chetan Rathod", "Noida Sector 15", "Noida", "Delhi", " 234357", "976298543", "chetan@gmail.com"));
        listpersonInCity.Add(new Person("Vishal singh", "Noida Sector 16", "Noida", "Delhi", " 234357", "9762794304", "vishal@gmail.com"));
        listpersonInCity.Add(new Person("Kartik Aryan", "Noida Sector 17", "Noida", "Delhi", " 234357", "9767449230", "kartik@gmail.com"));

    }
    private static void doSetDemo()
    {
        Console.WriteLine("In doSetDemo");

        HashSet<string> set = new HashSet<string>();
        set.Add("Chetan Rathod");
        set.Add("Vijay Raj");
        set.Add("Kishan Singh");
        set.Add("Chetan Rathod");
        set.Add("Vishal singh");
        set.Add("Kartik Aryan");

        foreach (var element in set)
        {
            Console.WriteLine(element);
        }
    }




}
}