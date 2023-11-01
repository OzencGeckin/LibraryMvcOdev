namespace LibraryMvcOdev_1.Models.Entites
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Relational Properties
        public virtual ICollection<Book> Books { get; set; }
    }
}
