class Library
{
    private List<Book> books = new List<Book>();

    /// <summary>
    /// Добавляет книгу в библиотеку
    /// </summary>
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine("Книга добавлена: " + book.Title);
    }

    /// <summary>
    /// Выдаёт книгу, если она существует и доступна
    /// </summary>
    public void BorrowBook(int id)
    {
        Book book = FindBook(id);

        if (book == null)
        {
            Console.WriteLine("Книга не найдена.");
            return;
        }

        if (book.IsAvailable == false)
        {
            Console.WriteLine("Книга уже выдана.");
            return;
        }

        book.IsAvailable = false;
        Console.WriteLine("Книга выдана: " + book.Title);
    }


    /// <summary>
    /// Возвращает выданную книгу в библиотеку
    /// </summary>
    public void ReturnBook(int id)
    {
        Book book = FindBook(id);

        if (book == null)
        {
            Console.WriteLine("Книга не найдена.");
            return;
        }

        if (book.IsAvailable == true)
        {
            Console.WriteLine("Книга уже возвращена.");
            return;
        }

        book.IsAvailable = true;
        Console.WriteLine("Книга возвращена: " + book.Title);
    }

    /// <summary>
    /// Ищет книгу по идентификатору
    /// </summary>
    public Book FindBook(int id)
    {
        foreach (Book book in books)
        {
            if (book.Id == id)
            {
                return book;
            }
        }

        return null;
    }
}
