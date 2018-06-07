using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Social_Media_Posts
{
    class Program
    {
        static Dictionary<string, Dictionary<string, string>> postComments = 
            new Dictionary<string, Dictionary<string, string>>();
        static Dictionary<string, int> postLikes = 
            new Dictionary<string, int>();
        static Dictionary<string, int> postDislikes = 
            new Dictionary<string, int>();

        static void Main(string[] args)
        {


            string input = Console.ReadLine();

            while (input != "drop the media")
            {
                string[] tokens = input.Split(' ');
                string command = tokens[0];
                string postArticle = tokens[1];

                switch (command)
                {
                    case "post": CreatePost(postArticle); break; // get metod 1
                    case "like": LikePost(postArticle); break; // get metod 2
                    case "dislike": DislikePost(postArticle); break; // get metod 3
                    case "comment":
                        string userName = tokens[2];
                        string comment =  string.Join(" ", tokens.Skip(3).ToArray()); // propuskame purvite 3 elementa
                        CommentPost(postArticle, userName, comment); // get metod 4
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var postItem in postComments)
            {
                string postArticle = postItem.Key;
                int likes = postLikes[postArticle];
                int dislikes = postDislikes[postArticle];

                Dictionary<string, string> commentBox = postItem.Value;

                Console.WriteLine("Post: {0} | Likes: {1} | Dislikes: {2}", 
                    postArticle,
                    likes,
                    dislikes);

                Console.WriteLine("Comments:");

                if (commentBox.Count == 0)
                {
                    Console.WriteLine("None");
                }

                foreach (var commentItem in commentBox)
                {
                    string user = commentItem.Key;
                    string currentComment = commentItem.Value;
                 
                    Console.WriteLine("*  {0}: {1}", user, currentComment);
                }
            }
        }

        static void CreatePost(string postArticle)
        {
            postComments.Add(postArticle, new Dictionary<string, string>());
            postLikes.Add(postArticle, 0);
            postDislikes.Add(postArticle, 0);

        }
        static void LikePost(string postArticle)
        {
            postLikes[postArticle]++;
        }
        static void DislikePost(string postArticle)
        {
            postDislikes[postArticle]++;
        }
        static void CommentPost(
            string postArticle, 
            string userName, 
            string comment)
        {
            postComments[postArticle].Add(userName, comment);
        }
    }
}
