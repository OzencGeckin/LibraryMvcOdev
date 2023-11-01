using LibraryMvcOdev_1.Models.Authors.PureVms;
using LibraryMvcOdev_1.Models.Authors.ResponseModels;
using LibraryMvcOdev_1.Models.Entites;

namespace LibraryMvcOdev_1.Models.MapperClasses
{
    public  static class AuthorMapper
    {
        public static AuthorResponseModel GetAuthorResponseModel(AuthorResponseModel author) 
        {
            return new()
            {
                ID = author.ID,
                FirstName = author.FirstName,
                LastName = author.LastName
            };
        }
       public static AuthorVM GetAuthorVM(Author author) 
        {
            return new()
            {
                ID = author.ID,
                FirstName = author.LastName, LastName = author.FirstName
            };
        }
    }
}
