

enum ArticleType
{
    Food,
    Clothing,
    Electronics,
    Furniture
}

enum ClientType
{
    Regular,    
    Priority,
    VIP
}

enum PayType
{
    Cash,
    Card
}

class Student
{
    string lastname;
    string firstname;
    string middlename;
    string group;
    int age;
    int[][] marks =
    {
    new int[] {},
    new int[] {},
    new int[] {}
    };

    public Student(string lastname, string firstname, string middlename, string group, int age)
    {
        this.lastname = lastname;
        this.firstname = firstname;
        this.middlename = middlename;
        this.group = group;
        this.age = age;
    }

    //0 - programming
    //1 - administration
    //2 - design

    public void set_mark(string subject, int mark)
    {
        if (subject == "programming")
        {
            Array.Resize(ref marks[0], marks[0].Length + 1);
            marks[0][marks[0].Length - 1] = mark;
        }
        else if (subject == "administration")
        {
            Array.Resize(ref marks[1], marks[1].Length + 1);
            marks[1][marks[1].Length - 1] = mark;
        }
        else if (subject == "design")
        {
            Array.Resize(ref marks[2], marks[2].Length + 1);
            marks[2][marks[2].Length - 1] = mark;
        }
        else
        {
            Console.WriteLine("This subject is not existing");
        }
    }


    public int Get_mark(string subject, int number_mark)
    {
        if (subject == "programming")
        {
            if(number_mark >= 0 && number_mark < marks[0].Length)
            {
                return marks[0][number_mark];
            }
            else
            {
                Console.WriteLine("This mark is not existing");
                return -1;
            }
        }
        else if (subject == "administration")
        {
            if (number_mark >= 0 && number_mark < marks[1].Length)
            {
                return marks[1][number_mark];
            }
            else
            {
                Console.WriteLine("This mark is not existing");
                return -1;
            }
        }
        else if (subject == "design")
        {
            if (number_mark >= 0 && number_mark < marks[2].Length)
            {
                return marks[2][number_mark];
            }
            else
            {
                Console.WriteLine("This mark is not existing");
                return -1;
            }
        }
        else
        {
            Console.WriteLine("This subject is not existing");
            return 0;
        }
    }


    public double sum_average(string subject)
    {
        if (subject == "programming")
        {
            if (marks[0].Length != 0)
            {
                return marks[0].Sum() / marks[0].Length;
            }
            else
            {
                return 0;
            }
        }
        else if (subject == "administration")
        {
            if (marks[1].Length != 0)
            {
                return marks[1].Sum() / marks[1].Length;
            }
            else
            {
                return 0;
            }
        }
        else if (subject == "design")
        {
            if (marks[2].Length != 0)
            {
                return marks[2].Sum() / marks[2].Length;
            }
            else
            {
                return 0;
            }
        }
        else
        {
            Console.WriteLine("This subject is not existing");
            return -1;
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Lastname: {lastname}");
        Console.WriteLine($"Firstname: {firstname}");
        Console.WriteLine($"Middlename: {middlename}");
        Console.WriteLine($"Group: {group}");
        Console.WriteLine($"Age: {age}");

        Console.Write("Programming: ");
        foreach (int mark in marks[0])
        {
            Console.Write(mark + " ");
        }
        Console.WriteLine();

        Console.Write("Administration: ");
        foreach (int mark in marks[1])
        {
            Console.Write(mark + " ");
        }
        Console.WriteLine();

        Console.Write("Design: ");
        foreach (int mark in marks[2])
        {
            Console.Write(mark + " ");
        }
        Console.WriteLine();
    }
}