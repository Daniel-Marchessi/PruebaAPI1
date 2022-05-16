using System;
using System.Collections.Generic;

namespace PruebaAPI1.Views
{
    public class CommentModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public ICollection<CommentModel> Comments { get; set; }



    }
}
