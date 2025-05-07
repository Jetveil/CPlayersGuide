// --- What comes next

// Console.WriteLine("Where am I?");
// Console.WriteLine("How did i get here?");
// Console.WriteLine("What's your name?");
// Console.WriteLine("Who are you, guys?");
// Console.WriteLine("Do you have guesses about Uncoded one?");

// --- Consolas and Telim

// Console.WriteLine("Bread is ready!");
// Console.WriteLine("Who is the bread for?");
// string name = Console.ReadLine();
// if (name == null)
// {
//     Console.WriteLine("Incorrect name!");
//     name = "Wanderer";
// }
// Console.WriteLine("Noted:" + name + " will get the bread");


// --- The thing namer 3000

// Console.WriteLine("What kind of thing are we talking about?");
// string a = Console.ReadLine(); /* This var is reading user input */
// Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
// string b = Console.ReadLine(); // This var is reading user input
// string c = " of Doom"; // This var is writing to the console
// string d = "3000"; /* This var is writing to the console */
// Console.WriteLine("The " + b + " " + a + c + " " + d + "!");

// --- The Variable Shop

// byte aByte = 255;
// short aShort = 32_767;
// short bShort = -32_768;
// int aInt = 2_147_483_647;
// int bInt = -2_147_483_648;
// long aLong = 9_223_372_036_854_775_807;
// long bLong = -9_223_372_036_854_775_807;
// sbyte aSByte = -127;
// ushort aUShort = 65_535;
// uint aUInt = 4_294_967_295;
// ulong aULong = 18_446_744_073_709_551_615;
// float aFloat = 3.4028235E+38F; // 10^38
// double aDouble = 1.7976931348623157E+308; // 10^308
// decimal aDecimal = 7.9228162514264337593543950335m; // 10^28
//
// Console.WriteLine(aByte);
// Console.WriteLine(aShort);
// Console.WriteLine(bShort);
// Console.WriteLine(aInt);
// Console.WriteLine(bInt);
// Console.WriteLine(aLong);
// Console.WriteLine(bLong);
// Console.WriteLine(aSByte);
// Console.WriteLine(aUShort);
// Console.WriteLine(aUInt);
// Console.WriteLine(aULong);
// Console.WriteLine(aFloat);
// Console.WriteLine(aDouble);
// Console.WriteLine(aDecimal);

// --- The triangle farmer

// Console.WriteLine("Enter the width of the triangle:");
// string inputWidth = Console.ReadLine();
// float width = float.Parse(inputWidth);
//
// Console.WriteLine("Enter the height of the triangle:");
// string inputHeight = Console.ReadLine();
// float height = float.Parse(inputHeight);
// float area = width * height / 2f;
// Console.WriteLine("Area of the triangle is: " + area);

// --- The Four Sisters and the Duckbear

// Console.WriteLine("How many choco egg collected today?");
// string inputEggsGathered = Console.ReadLine();
// int eggsGathered = int.Parse(inputEggsGathered);
// int eggPerSister = eggsGathered / 4;
// float eggsToDuckbear = eggsGathered % 4;
// Console.WriteLine("Each sister gets " + eggPerSister + " eggs.");
// Console.WriteLine("Duckbear gets " + eggsToDuckbear + " eggs.");


// --- The Dominion of Kings

// Console.WriteLine("Amount of Estates you have:");
// int estates = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Amount of Duchies you have:");
// int duchies = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Amount of Provinces you have:");
// int provinces = Convert.ToInt32(Console.ReadLine());
// int total = estates + duchies * 3 + provinces * 6;
// Console.WriteLine("Total amount of points you have:" + total);


// float num = 123.456f;
// double newDoubleNum = num;
// int newIntNum = (int)num;
// Console.WriteLine(num);
// Console.WriteLine(newDoubleNum);
// Console.WriteLine(newIntNum);

// long longNum = 10;
// byte byteLongNum = (byte)longNum;
// Console.WriteLine(byteLongNum);

// Console.WriteLine("Press any key to exit: ");
// Console.ReadKey(true);

// Console.BackgroundColor = ConsoleColor.Yellow;
// Console.ForegroundColor = ConsoleColor.Black;
// Console.WriteLine("Ji");
// Console.Beep();

// --- The Defense of Consolas

Console.WriteLine("Target row:");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Target column:");
int column = int.Parse(Console.ReadLine());
Console.WriteLine("Deploy to:");

int rowDec = row - 1;
int colDec = column - 1;
int rowInc = row + 1;
int colInc = column + 1;

Console.WriteLine($"({row}, {colDec})");
Console.WriteLine($"({rowDec}, {column})");
Console.WriteLine($"({row}, {colInc})");
Console.WriteLine($"({rowInc}, {column})");