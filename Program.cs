using System;
class Program{
    public static void Main(string []args){
        Personal1[] personals = InterputPersonals();
        Personal2[] personals2 = InterputPersonals2();
        string selectMenu = SelectMenu();
        if(selectMenu == "a"){
            Console.WriteLine("---Shop---");
            PrintShopsInfo(personals);
        }
        if(selectMenu == "b"){
            Console.WriteLine("---Co-founder---");
            PrintPersonalsInfo(personals);
        }
        if(selectMenu == "c"){
            Console.WriteLine("---Employee---");
            PrintPersonalsInfo2(personals2);
        }
        if(selectMenu == "d"){
            Console.WriteLine("---Money---");
            Console.WriteLine("0");
        }
    }


    public static Personal1[] InterputPersonals(){
        Personal1[] personals = new Personal1[3];

        for(int index =0 ; index< personals.Length; index++){
            Console.WriteLine("****Input Co-founder : {0} *****",index+1);
            Personal1 personal = new Personal1(InputValue(),InputNameKFC(),InputName(),InputSurname(),InputNumber());
            
            personals[index] = personal;

            Console.WriteLine("*************");

        }
        return personals;
    }
    public static string SelectMenu(){
        Console.Write("Select Menu :a.Shop : b.Co-founder : c.Employee : d.Money : ");
        return Console.ReadLine();
    }
    public static void PrintPersonalsInfo(Personal1[] personals){
        Array.ForEach(personals, personal=>Console.WriteLine(personal.PrintPersonalInfo()));
    }
    public static void PrintShopsInfo(Personal1[] personals){
        Array.ForEach(personals, personal=>Console.WriteLine(personal.PrintShopInfo()));
    }
    public static string InputValue(){
        Console.Write("Input Value : ");

        return Console.ReadLine();
    }
    public static string InputNameKFC(){
        Console.Write("Input Name KFC : ");

        return Console.ReadLine();
    }
    public static string InputName(){
        Console.Write("Input Name : ");

        return Console.ReadLine();
    }
    public static string InputSurname(){
        Console.Write("Input Surname : ");

        return Console.ReadLine();
    }
    public static string InputNumber(){
        Console.Write("Input Number : ");

        return Console.ReadLine();
    }

    public static Personal2[] InterputPersonals2(){
        Personal2[] personals2 = new Personal2[5];

        for(int index =0 ; index< personals2.Length; index++){
            Console.WriteLine("****Input Employee : {0} *****",index+1);
            Personal2 personal = new Personal2(InputRole(),InputName2(),InputSurname2(),InputAge(),InputMoney());
            
            personals2[index] = personal;

            Console.WriteLine("*************");

        }
        return personals2;
    }
    public static void PrintPersonalsInfo2(Personal2[] personals){
        Array.ForEach(personals, personal=>Console.WriteLine(personal.PrintPersonalInfo()));
    }
    public static string InputRole(){
        Console.Write("Input Role : ");

        return Console.ReadLine();
    }
    public static string InputName2(){
        Console.Write("Input Name : ");

        return Console.ReadLine();
    }
    public static string InputSurname2(){
        Console.Write("Input Surname : ");

        return Console.ReadLine();
    }
    public static string InputAge(){
        Console.Write("Input Age : ");

        return Console.ReadLine();
    }
    public static string InputMoney(){
        Console.Write("Input Money : ");

        return Console.ReadLine();
    }

}
