
using System.Collections.Generic;

namespace PruebaAPI1.Views
{
    public class PostModel
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }
        public ICollection<UserModel> Post { get; set; }


    }
}
