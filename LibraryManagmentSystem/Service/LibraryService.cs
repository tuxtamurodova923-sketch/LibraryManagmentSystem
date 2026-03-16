public class LibraryService : ILibraryService
{
    private Book[] books = new Book[100];
    private int count = 0;

    public void AddBook(Book book)
    {
        books[count] = book;
        count++;

        Console.WriteLine("Kitob qo'shildi");
    }

    public void GetAllBooks()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(
                books[i].Id + " - " +
                books[i].Title + " - " +
                books[i].Author + " - " +
                (books[i].IsBorrowed ? "Band" : "Bo'sh")
            );
        }
    }

    public void BorrowBook(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (books[i].Id == id)
            {
                if (books[i].IsBorrowed)
                {
                    Console.WriteLine("Kitob allaqachon band");
                }
                else
                {
                    books[i].IsBorrowed = true;
                    Console.WriteLine("Kitob ijaraga berildi");
                }
                return;
            }
        }

        Console.WriteLine("Kitob topilmadi");
    }

    public void ReturnBook(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (books[i].Id == id)
            {
                books[i].IsBorrowed = false;
                Console.WriteLine("Kitob qaytarildi");
                return;
            }
        }

        Console.WriteLine("Kitob topilmadi");
    }
}