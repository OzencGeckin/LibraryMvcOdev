namespace LibraryMvcOdev_1.Models.Entites
{
    public class BookTag : BaseEntity
    {
        public int BookID { get; set; }
        public int TagID { get; set; }

        //Relational Properties

        public virtual Book Book { get; set; }
        public virtual Tag Tag { get; set; }

    }
}
