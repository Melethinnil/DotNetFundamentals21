using Exercise_2;

string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"\event.txt";
string discountCode = "";
List <Attendee> attendees = new List <Attendee> ();

//Default attendees for testing purposes
/*attendees.Add(new Attendee("Amanda", "Holmgren", "amanda.holmgren@domain.com", 31, ""));
attendees.Add(new Attendee("Wilhelm", "Axelsson", "wilhelmtheman@domain.com", 19, "hummus"));
attendees.Add(new Attendee("Jessica", "Asher", "jessica_a@domain.com", 27, "watermelon, peanuts"));
attendees.Add(new Attendee("Karl", "Warren", "kwarren@domain.com", 44, "None"));*/

//Main program loop
while (true)
{
    Console.Clear();
    Console.WriteLine("Available commands:\n" +
        "1. Add attendee\n" +
        "2. Show/edit attendees\n" +
        "3. Generate discount code\n" +
        "4. Save data\n" +
        "5. Load data\n" +
        "6. Exit program");

    Console.Write("\nPlease enter a command number: ");
    int command = int.Parse(Console.ReadLine());

    switch (command)
    {
        case 1:
            AddAttendee();
            break;
        case 2:
            ShowAttendees();
            break;
        case 3:
            GenerateDiscountCode();
            break;
        case 4:
            SaveData();
            break;
        case 5:
            LoadData();
            break;
        case 6:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid command. Please enter a valid command.");
            Console.ReadLine();
            break;
    }
}

void GenerateDiscountCode()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine($"Current discount code: {discountCode}");
        Console.Write("\nGenerate a new discount code? (y/n) ");
        string command = Console.ReadLine();
        if (command == "y")
        {
            int year = int.Parse(DateTime.Now.Year.ToString().Substring(2));    //Get the last 2 digits of the current year
            Random random = new Random(DateTime.Now.Millisecond);
            string randomKey = ((char)random.Next('A', 'Z')).ToString() + random.Next(10, 99).ToString() + ((char)random.Next('A', 'Z')).ToString();
            discountCode = $"PARTY{year}-{randomKey}";
        }
        else if (command == "n")
            return;
    }
}

void LoadData()
{
    Console.Clear();
    Console.WriteLine($"File path: {filePath}");
    Console.Write("Type the file path to load from (leave empty to use the current file path), then press Enter: ");
    string path = Console.ReadLine();

    if (path != "" && path != null)
    {
        filePath = path;
    }

    attendees.Clear();
    StreamReader file = File.OpenText(filePath);
    discountCode = file.ReadLine();
    string person = file.ReadLine();
    while(person != null)
    {
        string[] data = person.Split(';', 5);
        attendees.Add(new Attendee(data[0], data[1], data[2], int.Parse(data[3]), data[4]));
        person = file.ReadLine();
    }
    file.Close();
}

void SaveData()
{
    Console.Clear();
    Console.WriteLine($"File path: {filePath}");
    Console.Write("Type the file path to save to (leave empty to use the current file path), then press Enter: ");
    string path = Console.ReadLine();

    if(path != "" && path != null)
    {
        filePath = path;
    }

    StreamWriter file = File.CreateText(filePath);
    file.WriteLine(discountCode);
    foreach (Attendee attendee in attendees)
    {
        file.WriteLine($"{attendee.firstName};{attendee.lastName};{attendee.emailAdress};{attendee.age};{attendee.allergies}");
    }
    file.Close();
}

void ShowAttendees()
{
    Console.Clear();
    foreach(Attendee attendee in attendees)
    {
        Console.WriteLine($"{attendees.IndexOf(attendee)+1}. {attendee.firstName} {attendee.lastName} ({attendee.emailAdress})");
    }

    Console.WriteLine("\nAvailable commands:\n" +
        "1. Edit attendee\n" +
        "2. Remove attendee\n" +
        "3. Return to main menu");

    Console.Write("\nPlease enter a command number: ");
    int command = int.Parse(Console.ReadLine());

    switch(command)
    {
        case 1:
            Console.Write("Enter the number of the attendee to edit: ");
            EditAttendee(int.Parse(Console.ReadLine())-1);
            break;
        case 2:
            Console.Write("Enter the number of the attendee to remove: ");
            RemoveAttendee(int.Parse(Console.ReadLine())-1);
            break;
        case 3:
            return;
        default:
            Console.WriteLine("Invalid command. Returning to main menu.");
            Console.ReadLine();
            break;
    }
}

void RemoveAttendee(int index)
{
    attendees.RemoveAt(index);
}

void EditAttendee(int index)
{
    Attendee attendee = attendees[index];

    //Loop until done editing
    while (true)
    {
        Console.Clear();
        Console.WriteLine($"{attendee.firstName} {attendee.lastName}\n{attendee.emailAdress}\n{attendee.age} years old\nAllergies: {attendee.allergies}");

        Console.WriteLine("\nAvailable commands:\n" +
            "1. Change first name\n" +
            "2. Change last name\n" +
            "3. Change email adress\n" +
            "4. Change age\n" +
            "5. Change allergies\n" +
            "6. Return to main menu");

        Console.Write("\nPlease enter a command number: ");
        int command = int.Parse(Console.ReadLine());

        switch (command)
        {
            case 1:
                Console.Clear();
                Console.Write("Enter the new first name: ");
                attendee.firstName = Console.ReadLine();
                break;
            case 2:
                Console.Clear();
                Console.Write("Enter the new last name: ");
                attendee.lastName = Console.ReadLine();
                break;
            case 3:
                Console.Clear();
                Console.Write("Enter the new email adress: ");
                attendee.emailAdress = Console.ReadLine();
                break;
            case 4:
                Console.Clear();
                Console.Write("Enter the new age: ");
                attendee.age = int.Parse(Console.ReadLine());
                break;
            case 5:
                Console.Clear();
                Console.Write("Enter the new first name: ");
                attendee.allergies = Console.ReadLine();
                break;
            case 6:
                return;
        }
    }
}

void AddAttendee()
{
    Console.Clear();
    Console.Write("Enter the attendant's first name: ");
    string firstName = Console.ReadLine();

    Console.Clear();
    Console.Write("Enter the attendant's last name: ");
    string lastName = Console.ReadLine();

    Console.Clear();
    Console.Write("Enter the attendant's email adress: ");
    string email = Console.ReadLine();

    Console.Clear();
    Console.Write("Enter the attendant's age: ");
    int age = int.Parse(Console.ReadLine());

    Console.Clear();
    Console.Write("Enter the attendant's allergies (if any): ");
    string allergies = Console.ReadLine();
    if (allergies == "" || allergies == null)
        allergies = "None";

    while (true)
    {
        Console.Clear();
        Console.WriteLine($"{firstName} {lastName}\n{email}\n{age} years old\nAllergies: {allergies}");
        Console.Write("\nAdd this attendant? (y/n) ");
        string command = Console.ReadLine();
        if (command == "y")
        {
            attendees.Add(new Attendee(firstName, lastName, email, age, allergies));
            return;
        }
        else if (command == "n")
            return;
    }
}