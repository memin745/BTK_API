using BookDemoo.Models;
namespace BookDemoo.Data
{
    public static class ApplicationContext
    {
        public static List<Book> Books { get; set; }
        static ApplicationContext()
        {
            Books = new List<Book>()
            {
                new Book(){Id=1,Title="Enjoy Gramer",Price=75},
                new Book(){Id=2,Title="Succes Gramer",Price=85},
                new Book(){Id=3,Title="Read Gramer",Price=75}
            };
        }
    }
}
