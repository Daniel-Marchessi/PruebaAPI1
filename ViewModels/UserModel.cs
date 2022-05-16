namespace PruebaAPI1.Views
{
    public class UserModel
    {

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }


        public PostModel Post { get; set; }

        public CommentModel Coments { get; set; }
    }

    
}
