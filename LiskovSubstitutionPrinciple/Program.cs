using LiskovSubstitutionPrinciple.WithoutLSP;

namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region WithoutLSP

            PostDatabase postDatabase = new PostDatabase();
            List<string> posts = new List<string>()
            {
                "Original Post",
                "#Tag Post",
                "@Mention Post"
            };

            Post postObj;
            foreach (string post in posts)
            {
                if (post.StartsWith("#"))
                {
                    postObj = new TagPost();
                }
                else if (post.StartsWith("@"))
                {
                    postObj = new MentionPost();
                }
                else
                {
                    postObj = new Post();
                }

                var result = postObj.CreateOriginalPost(postDatabase, post);

                Console.WriteLine(result);//Original Post: Original Post
                                          //Original Post: #Tag Post
                                          //Original Post: @Mention Post

            }

            #endregion

            //If you have class B inherits from class A then class A should be replaceable by class B without any changes

            #region WithLSP

            WithLSP.PostDatabase postDatabase2 = new WithLSP.PostDatabase();
            List<string> posts2 = new List<string>()
            {
                "Original Post",
                "#Tag Post",
                "@Mention Post"
            };

            WithLSP.Post postObj2;

            foreach (string post in posts2)
            {
                if (post.StartsWith("#"))
                {
                    postObj2 = new WithLSP.TagPost();
                }
                else if (post.StartsWith("@"))
                {
                    postObj2 = new WithLSP.MentionPost();
                }
                else
                {
                    postObj2 = new WithLSP.Post();
                }

                var result = postObj2.CreatePost(postDatabase2, post);

                Console.WriteLine(result); //Original Post: Original Post
                                           //#Tag Post: #Tag Post
                                           //@Mention Post: @Mention Post

            }

            #endregion
        }
    }
}
