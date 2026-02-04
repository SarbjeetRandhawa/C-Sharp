using System;
namespace practice
{
    class School
    {
        public string RoomName { get; set; }
        public int Floor { get; set; }

        public School(string roomname , int floor)
        {
            RoomName = roomname;
            Floor = floor;
        }

         public virtual void display()
        {
            Console.WriteLine($"Room name is {RoomName} on floor {Floor}");
        }

    }

    class Library : School
    {
        public string Book { get; set; }
        public int BookId { get; set; }

        public Library(string roomname, int floor, string book, int bookid) : base(roomname, floor)
        {
            Book = book;
            BookId = bookid;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine($"book Id is {BookId} name of the book is {Book}");
            
        }
    }

    class ComputerLab : School
    {
        public int PcNo { get; set; }
        public bool Working { get; set; }

        public ComputerLab(string roomname, int floor, int pcno, bool working) : base(roomname, floor)
        {

            PcNo = pcno;
            Working = working;

        }

        public string isWorking()
        {
            if (Working)
            {
                return "working fine";
            }
            else
            {
                return "not working";
            }
        }


        public override void display()
        {
            base.display();
            Console.WriteLine($"Pc no is {PcNo} and pc is {isWorking()}");
        }
    }

    class Program
    {
        public static void Main()
        {
            Library l1 = new("Library1" , 2 , "Goosebumbs" , 202);
            Library l2 = new("Library2", 2, "Great Wizard", 102);

            ComputerLab c1 = new("ComputerLab1", 4, 20, true);
            ComputerLab c2 = new("ComputerLab1", 4, 10, false);

            l1.display();
            l2.display();
            

            c1.display();
            c2.display();
            

        }
    }
}