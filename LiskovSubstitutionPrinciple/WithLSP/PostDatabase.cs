namespace LiskovSubstitutionPrinciple.WithLSP
{
    public class PostDatabase
    {
        public string CreateOriginalPost(string post)
            => $"Original Post: {post}";

        public string CreateTagPost(string post)
            => $"#Tag Post: {post}";

        public string CreateMentionPost(string post)
            => $"@Mention Post: {post}";
    }
}
