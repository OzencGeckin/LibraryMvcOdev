namespace LibraryMvcOdev_1.Models.Entites
{
    public class Shelf : BaseEntity
    {
        public string No { get; set; }
        public int? RoomID { get; set; }



        //Relational Properties
        public virtual Room Room { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
