namespace LibraryMvcOdev_1.Models.Entites
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public int PageNumber { get; set; }

        public int? ShelfID { get; set; }
        public int? AuthorID { get; set; }
        public int? CategoryID { get; set; }

        //Relational Properties

        public virtual Author Author { get; set; }

        public virtual Shelf Shelf { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<BookTag> BookTags { get; set; }
    }
}
