using System;
using EntityFrameworkSample.Entities;
using System.Data.SqlClient;
namespace EntityFrameworkSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new BookContext())
            {
                //Sample Data to Users
                var User1 = new User() { User_Name = "Bill" };
                ctx.Users.Add(User1);
                var User2 = new User() { User_Name = "Sanaz" };
                ctx.Users.Add(User2);
                var User3 = new User() { User_Name = "sara" };
                ctx.Users.Add(User3);
                var User4 = new User() { User_Name = "Boshra" };
                ctx.Users.Add(User4);
                var User5 = new User() { User_Name = "Mohammad" };
                ctx.Users.Add(User5);
                ctx.SaveChanges();


                //Sample Data to Books

                var Book1 = new Book() { Book_Name = "hafez" };
                ctx.Books.Add(Book1);
                var Book2 = new Book() { Book_Name = "Sadi" };
                ctx.Books.Add(Book2);
                var Book3 = new Book() { Book_Name = "Molavi" };
                ctx.Books.Add(Book3);
                var Book4 = new Book() { Book_Name = "Roodaki" };
                ctx.Books.Add(Book4);
                var Book5 = new Book() { Book_Name = "Mohammad" };
                ctx.Books.Add(Book5);
                ctx.SaveChanges();

                //Sample Data to Shelfs
                var Shelf1 = new Shelf() { Shelf_Name = "Tarikh", User_ID = 1 };
                ctx.Shelfs.Add(Shelf1);
                var Shelf2 = new Shelf() { Shelf_Name = "sher", User_ID = 2 };
                ctx.Shelfs.Add(Shelf2);
                var Shelf3 = new Shelf() { Shelf_Name = "Erfani", User_ID = 2 };
                ctx.Shelfs.Add(Shelf3);
                ctx.SaveChanges();


                //Sample Data to Book by Shelfs
                var bbsh1 = new BookbyShelf() { Book_ID = 1, Shelf_ID = 1 };
                ctx.BookbyShelves.Add(bbsh1);

                var bbsh2 = new BookbyShelf() { Book_ID = 2, Shelf_ID = 1 };
                ctx.BookbyShelves.Add(bbsh2);

                var bbsh3 = new BookbyShelf() { Book_ID = 3, Shelf_ID = 2 };
                ctx.BookbyShelves.Add(bbsh3);

                var bbsh4 = new BookbyShelf() { Book_ID = 4, Shelf_ID = 3 };
                ctx.BookbyShelves.Add(bbsh4);

                var bbsh5 = new BookbyShelf() { Book_ID = 5, Shelf_ID = 2 };
                ctx.BookbyShelves.Add(bbsh5);

                ctx.SaveChanges();
            }

        }
    }
}
