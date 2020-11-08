using System;

namespace School
{
    class Program
    {
    public class Stdent
    {
        private int age;
        private string name;
        private Parent parent;
        public Stdent(int age, string name,Parent parent)
        {
            this.age = age;
            this.name = name;
            this.parent = parent;
        }
        public override string ToString()
        {
            string messeg = "\t|Student| \n\tName: " + this.name + "\n\tAge: " + this.age + "\n\t____^____\n\n" +this.parent;
            return messeg.ToUpper();
        }
    }

    public class Parent
    {
        private string nameParent;
        private string phoneParent;
        public Parent( string nameParent,string phone)
        {
            this.nameParent = nameParent;
            this.phoneParent = phone;
        }
        public override string ToString()
        {
            string messeg = "\t|Parent| \n\tName: " + this.nameParent+"\n\tPhone: "+this.phoneParent;
            return messeg.ToUpper();
        }
    }
        public static void input_Parent_Stdent()
        {
            start: try
            {
                Console.WriteLine("\tParent Please Put Your Name:");
                string Name = Console.ReadLine();
                Console.WriteLine("\tParent Please Put Your Phone:");
                string Phone = Console.ReadLine();
                Parent p1 = new Parent(Name, Phone);
                Console.WriteLine("_________________");
                Console.WriteLine("\tStdent Please Put Your Name:");
                string NameStdent = Console.ReadLine();
                Console.WriteLine("\tStdent Please Put Your Age:");
                int AgeStdent = int.Parse(Console.ReadLine());
                Stdent s1 = new Stdent(AgeStdent, NameStdent, p1);
                Console.WriteLine("\n" + p1);
                Console.WriteLine("____________");
                Console.WriteLine(s1);
            }
            catch(Exception)
            {
                to_try: 
                Console.WriteLine("Somting Worng!");
                Console.WriteLine("You Want To try Again (Y/N)?");
                char check = char.Parse(Console.ReadLine());
                if (check == 'y' || check == 'Y')
                    goto start;
                if (check == 'N' || check == 'n')
                    Console.WriteLine("END");
                else
                    goto to_try;
            }

        }
   
        static void Main(string[] args)
        {
            try 
            {
                input_Parent_Stdent();
            }
            catch (Exception)
            {
                Console.WriteLine("Somting Worng!");
            }
            finally
            {
                Console.WriteLine("all is good!");
            }
        }
    }
}
