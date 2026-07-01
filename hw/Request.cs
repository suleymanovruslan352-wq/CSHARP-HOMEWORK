struct Request
{
    public int order_code;
    public Client client;
    public string date;
    public RequestItem products;
    public double sum_orders;

    public Request(int order_code, Client client, string date,
                   RequestItem products, double sum_orders)
    {
        this.order_code = order_code;
        this.client = client;
        this.date = date;
        this.products = products;
        this.sum_orders = sum_orders;
    }
}

enum PayType
{
    Cash,
    Card,
    BankTransfer
}