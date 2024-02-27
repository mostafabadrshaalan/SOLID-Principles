namespace LiskovSubstitutionPrinciple.WithoutLSP
{
    public class Post
    {
        public virtual string CreateOriginalPost(PostDatabase postDatabase, string post)
            => postDatabase.CreateOriginalPost(post);
    }

    public class TagPost : Post
    {
        public string CreateTagPost(PostDatabase postDatabase, string post)
            => postDatabase.CreateTagPost(post);
    }

    public class MentionPost : Post
    {
        public string CreateMentionPost(PostDatabase postDatabase, string post)
            => postDatabase.CreateMentionPost(post);
    }
}
