


double test = InputDoubleNumber("Please enter some number:");

Console.WriteLine(test);



double InputDoubleNumber(string str)
    {
        Console.WriteLine(str);
        
        bool isParsed = double.TryParse(Console.ReadLine(), out double number);

        if (isParsed)
        {
            return number;
        }
        else
        {
            Console.WriteLine("Incorrect input...");
            return InputDoubleNumber(str);
        }
    }