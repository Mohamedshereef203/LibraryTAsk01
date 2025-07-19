namespace NumbersTask01;

class Program1
{
    public static void showMenu()
    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("P - Print numbers");
        Console.WriteLine("A - add a number");
        Console.WriteLine("M - Display mean of the numbers");
        Console.WriteLine("S - Display the smallest number");
        Console.WriteLine("L - Display the largest number");
        Console.WriteLine("F - Search Number In The List");
        Console.WriteLine("O - Print How many Odd Number In The List ");
        Console.WriteLine("E - Print How many Even Number In The List ");
        Console.WriteLine("C - Clear All The List");
        Console.WriteLine("Q - Quit\n\n");
        Console.WriteLine("---------------------------------------------");
    }
    public static void printNumbers(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("[]- This List Is Empty.");
        }
        else
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("The Numbers In The List Are: ");
            Console.Write("[");
            for (int i = 0; i < numbers.Count; ++i)
            {
                Console.Write(" " + numbers[i] + " ");

            }
            Console.Write("]\n\n");
        }
    }
    public static void addNumbers(List<int> numbers)
    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Add A Number ");
        int addNumber = Convert.ToInt32(Console.ReadLine());
        if (numbers.Contains(addNumber))
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"The Number {addNumber} Already Exist  ");
            Console.WriteLine("The Add faild :(");
        }
        else
        {
            numbers.Add(addNumber);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"[{addNumber}] has been added");
        }
    }
    public static void average(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Unable To Calculate The Mean - No Data");
        }
        else if (numbers.Count != 0)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Count; ++i)
            {
                sum += numbers[i];
            }
            double avarage = sum / numbers.Count;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"The avarage of the List numbers :  {avarage}");
        }
    }
    public static void smallestNumbers(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Unable To Determine The Smallest Number - List Is Empty");
        }
        else
        {
            int min = numbers[0];
            for (int i = 1; i < numbers.Count; ++i)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"The Smallest Number in the List is : {min}");
        }
    }
    public static void largestNumbers(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Unable To Determine The Largest Number - List Is Empty");
        }
        else
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Count; ++i)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($" The Largest Number in the List is : {max}");
        }
    }
    public static void search(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("The List Is Empty ");
        }
        else
        {
            Console.WriteLine("Enter the Number You To know If the Number Exist Or Not ");
            string searchNumber = Console.ReadLine();
            int goal = int.Parse(searchNumber);
            int searchIndex = numbers.IndexOf(goal);
            if (searchIndex == -1)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"{goal} Not Found In The LIst :(");
            }
            else
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"The Number You Entered Is Exist : {goal}");
            }
        }
    }
    public static void odd(List<int> numbers)
    {
        int oddNumbers = 0;
        if (numbers.Count == 0)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Use 'A' First To Add Numbers ");
        }
        else
        {
            for (int i = 0; i < numbers.Count; ++i)
            {
                if (numbers[i] % 2 != 0)
                {
                    oddNumbers++;
                }
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"The Number Of Odd Numbers In The List Is : {oddNumbers}");
        }
    }
    public static void even(List<int> numbers)
    {
        int evenNumbers = 0;
        if (numbers.Count == 0)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Use 'A' First To Add Numbers ");
        }
        else
        {
            for (int i = 0; i < numbers.Count; ++i)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers++;
                }
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"The Number Of Even Numbers In The List Is : {evenNumbers}");
        }
    }
    public static void clear(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            Console.WriteLine("The List Already Empty ");
        }
        else
        {
            numbers.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("The List is Clear Now");
        }
    }

    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        char choice;
        do
        {
            showMenu();
            Console.WriteLine("Enter your Choice");
            choice = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine("\n");

            switch (choice)
            {
                case 'P':
                    {
                        printNumbers(numbers);
                        break;
                    }
                case 'A':
                    {
                        addNumbers(numbers);
                        break;
                    }
                case 'M':
                    {
                        average(numbers);
                        break;
                    }
                case 'S':
                    {
                        smallestNumbers(numbers);
                        break;
                    }
                case 'L':
                    {
                        largestNumbers(numbers);
                        break;
                    }
                case 'F':
                    {
                        search(numbers);
                        break;
                    }
                case 'O':
                    {
                        odd(numbers);
                        break;
                    }
                case 'E':
                    {
                        even(numbers);
                        break;
                    }
                case 'C':
                    {
                        clear(numbers);
                        break;
                    }
                case 'Q':
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Thank You for Using My Program ");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Unknown Selection, Please Try Again. ");
                        break;
                    }
            }
        } while (choice != 'Q');

    }
}