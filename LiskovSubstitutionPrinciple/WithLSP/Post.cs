namespace LiskovSubstitutionPrinciple.WithLSP
{
    public class Post
    {
        public virtual string CreatePost(PostDatabase postDatabase, string post) //Make it Virtual Method
            => postDatabase.CreateOriginalPost(post);
    }

    public class TagPost : Post
    {
        public override string CreatePost(PostDatabase postDatabase, string post)
            => postDatabase.CreateTagPost(post);
    }

    public class MentionPost : Post
    {
        public override string CreatePost(PostDatabase postDatabase, string post)
            => postDatabase.CreateMentionPost(post);
    }
}
