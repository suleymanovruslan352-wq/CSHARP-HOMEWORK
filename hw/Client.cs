struct Client
{
    public int client_code;
    public string client_firstname;
    public string client_lastname;
    public string client_middlename;
    public string address;
    public string telefonnumber;
    public int order_count;
    public double order_sum;

    public Client(int client_code, string client_firstname, string client_lastname,
                  string client_middlename, string address,
                  string telefonnumber, int order_count, double order_sum)
    {
        this.client_code = client_code;
        this.client_firstname = client_firstname;
        this.client_lastname = client_lastname;
        this.client_middlename = client_middlename;
        this.address = address;
        this.telefonnumber = telefonnumber;
        this.order_count = order_count;
        this.order_sum = order_sum;
    }
}
