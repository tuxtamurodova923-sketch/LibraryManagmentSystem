public interface ILibraryService
{
    void AddBook(Book book);
    void GetAllBooks();
    void BorrowBook(int id);
    void ReturnBook(int id);
}