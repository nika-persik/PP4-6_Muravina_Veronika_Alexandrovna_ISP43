Library library = new Library();

Book book1 = new Book();
book1.Id = 1;
book1.Title = "Преступление и наказание";
book1.Author = "Федор Достоевский";
library.AddBook(book1);

Book book2 = new Book();
book2.Id = 2;
book2.Title = "Мастер и Маргарита";
book2.Author = "Михаил Булгаков";
library.AddBook(book2);

Book book3 = new Book();
book3.Id = 3;
book3.Title = "Война и мир";
book3.Author = "Лев Толстой";
library.AddBook(book3);

library.BorrowBook(1);
library.ReturnBook(1);
library.ReturnBook(1);


Book book = library.FindBook(2);

if (book != null)
{
    Console.WriteLine("Найдена книга: " + book.Title);
    Console.WriteLine("Автор: " + book.Author);
    Console.WriteLine("Доступна: " + book.IsAvailable);
}

Console.ReadKey();