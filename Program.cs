using System;
using System.Collections.Generic;

public class MenuItem // property
{
     public class Appitizers
    {
        public string Appitizers_Items { get; set; }
        public string Description {get; set; }
        public double Price { get; set; }
        public string Catagories { get; set; }
        public string New_Items { get; set; }
    }
    public class Main_Course
    {
        public string Main_Course_Items { get; set; }
        public string Description {get; set; }
        public double Price { get; set;}
        public string Catagories { get; set; }
        public string New_Items { get; set; }
    }
    public class Dessert
    {
        public string Dessert_Items { get; set; }
        public string Description {get; set; }
        public double Price { get; set;}
        public string Catagories { get; set; }
        public string New_Items { get; set; }
    }

}
/////////////////////////////////////////////
public class AppitizerItemss
{
    public static void Main(string[] args)
    {
        MenuItem.Appitizers appitizer_One = new  MenuItem.Appitizers();
        appitizer_One.Appitizers_Items = "FIRE FRIES";
        appitizer_One.Description = "Crispy Outside, Fluffy Inside seasoned with our special Fire Seasonings!";
        appitizer_One.Price = 10.99;
        appitizer_One.Catagories = "Catagory: Appitizers";
        MenuItem.Appitizers appitizer_Two = new MenuItem.Appitizers();
        appitizer_Two.Appitizers_Items = "DUCK WINGS";
        appitizer_Two.Description = "Saucey but still crispy with every bite!";
        appitizer_Two.Price = 12.99;
        appitizer_Two.Catagories = "Catagory: Appitizers";
        System.Console.WriteLine(appitizer_One.Appitizers_Items + " ($" + appitizer_One.Price + ") " + appitizer_One.Description);
        System.Console.WriteLine(appitizer_One.Catagories);
        System.Console.WriteLine();

        MenuItem.Main_Course main_course_One = new MenuItem.Main_Course();
        main_course_One.Main_Course_Items = "Filet Migon";
        main_course_One.Description = "Seared to perfection with a bit of the char grill taste!";
        main_course_One.Price = 32.50;
        main_course_One.Catagories = "Catagory: Entrees";
        MenuItem.Main_Course main_course_Two = new MenuItem.Main_Course();
        main_course_Two.Main_Course_Items = "SeaKing Sushi Boat";
        main_course_Two.Description = "Fish freshly caught every morning!";
        main_course_Two.New_Items = "This is a new item!";
        main_course_Two.Price = 43.21;
        main_course_Two.Catagories = "Catagory: Entrees";
        System.Console.WriteLine(main_course_Two.Main_Course_Items + " ($" + main_course_Two.Price + ") " + main_course_Two.Description);
        System.Console.WriteLine(main_course_Two.Catagories);
        System.Console.WriteLine(main_course_Two.New_Items);
        System.Console.WriteLine();

        MenuItem.Dessert dessert_One = new MenuItem.Dessert();
        dessert_One.Dessert_Items = "Coconut Cream Pie";
        dessert_One.Description = "Everyone favorite!";
        dessert_One.Price = 8.99;
        dessert_One.Catagories = "Catagory: Dessert";
        MenuItem.Dessert dessert_Two = new MenuItem.Dessert();
        dessert_Two.Dessert_Items = "Creme Brulee";
        dessert_Two.Description = "Sweet an soft!";
        dessert_Two.Price = 10.00;
        dessert_Two.Catagories = "Catagory: Dessert";
        System.Console.WriteLine(dessert_One.Dessert_Items + " ($" + dessert_One.Price + ") " + dessert_One.Description);
        System.Console.WriteLine(dessert_One.Catagories);

        DateTime now = DateTime.Now;
        Console.WriteLine(now.ToString());
        
    }
}

