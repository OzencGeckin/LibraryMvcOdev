namespace LibraryMvcOdev_1.Models.Entites
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relational Properties

        public virtual ICollection<Book> Books { get; set; }
    }
}
