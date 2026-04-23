namespace Bookstore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Answer 5: Create Database
            using (var context = new BookStoreContext())
            {
                context.Database.EnsureCreated();
            }
            #endregion
        }
    }
}
