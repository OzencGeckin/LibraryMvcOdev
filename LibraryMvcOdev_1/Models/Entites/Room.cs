namespace LibraryMvcOdev_1.Models.Entites
{
    public class Room : BaseEntity
    {
        public string Name { get; set; }

        //Relational Properties
        public virtual ICollection<Shelf> Shelves { get; set; }
    }
}
