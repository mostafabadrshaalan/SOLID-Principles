namespace LiskovSubstitutionPrinciple.WithLSP
{
    public class PostDatabase
    {
        public string CreateOriginalPost(string post)
            => $"Original post: {post}";

        public string CreateTagPost(string post)
            => $"#tag post: {post}";

        public string CreateMentionPost(string post)
            => $"@mention post: {post}";
    }
}
