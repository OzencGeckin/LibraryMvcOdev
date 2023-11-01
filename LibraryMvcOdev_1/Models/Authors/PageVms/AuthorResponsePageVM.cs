using LibraryMvcOdev_1.Models.Authors.ResponseModels;

namespace LibraryMvcOdev_1.Models.Authors.PageVms
{
    public class AuthorResponsePageVM
    {
        public List<AuthorResponseModel> Authors { get; set; }
        public AuthorResponseModel Author { get; set; }
    }
}
