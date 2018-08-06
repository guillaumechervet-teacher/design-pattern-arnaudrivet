namespace Basket.OrientedObject.Infrastructure
{
    public interface IArticleDatabase
    {
        ArticleDatabase GetArticle(string id);
    }
}