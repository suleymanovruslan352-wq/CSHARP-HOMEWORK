struct RequestItem
{
    public Article article;
    public int order_count;

    public RequestItem(Article article, int order_count)
    {
        this.article = article;
        this.order_count = order_count;
    }
}
