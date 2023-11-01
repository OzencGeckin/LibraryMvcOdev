namespace LibraryMvcOdev_1.Models.Entites
{
    public class Tag : BaseEntity
    {
        public string Title { get; set; }

        //Relational Properties

        public virtual ICollection<BookTag> BookTags { get; set; }

    }
}
