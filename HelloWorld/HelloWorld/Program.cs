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

// Console.WriteLine("Target row:");
// int row = int.Parse(Console.ReadLine());
// Console.WriteLine("Target column:");
// int column = int.Parse(Console.ReadLine());
// Console.WriteLine("Deploy to:");
//
// int rowDec = row - 1;
// int colDec = column - 1;
// int rowInc = row + 1;
// int colInc = column + 1;
//
// Console.WriteLine($"({row}, {colDec})");
// Console.WriteLine($"({rowDec}, {column})");
// Console.WriteLine($"({row}, {colInc})");
// Console.WriteLine($"({rowInc}, {column})");

// --- Repearing the Clocktower

// Console.WriteLine("Enter the number:");
//
// string input = Console.ReadLine();
// int number = Convert.ToInt32(input);
//
// if (number % 2 == 0) {
//     Console.WriteLine("Left");
// } else {
//     Console.WriteLine("Right");
// }

// --- Watchtower

// Console.WriteLine("Enter X coordinate of the enemy:");
//
// string inputX = Console.ReadLine();
// int x = Convert.ToInt32(inputX);
//
// Console.WriteLine("Enter Y coordinate of the enemy:");
//
// string inputY = Console.ReadLine();
// int y = Convert.ToInt32(inputY);
//
// if (x < 0 && y > 0)
//     Console.WriteLine("Enemy is to the North-West!");
// else if (x == 0 && y > 0)
//     Console.WriteLine("Enemy is to the North!");
// else if (x > 0 && y > 0)
//     Console.WriteLine("Enemy is to the North-East!");
// else if (x < 0 && y == 0)
//     Console.WriteLine("Enemy is to the West!");
// else if (x == 0 && y == 0)
//     Console.WriteLine("Enemy is right HERE!");
// else if (x > 0 && y == 0)
//     Console.WriteLine("Enemy is to the East!");
// else if (x < 0 && y < 0)
//     Console.WriteLine("Enemy is to the South-West!");
// else if (x == 0 && y < 0)
//     Console.WriteLine("Enemy is to the South!");
// else if (x > 0 && y < 0)
//     Console.WriteLine("Enemy is to the South-East!");

// --- Buying inventory

// Console.WriteLine("The following items are available:");
// Console.WriteLine("1 – Rope");
// Console.WriteLine("2 – Torches");
// Console.WriteLine("3 – Climbing Equipment");
// Console.WriteLine("4 – Clean Water");
// Console.WriteLine("5 – Machete");
// Console.WriteLine("6 – Canoe");
// Console.WriteLine("7 – Food Supplies");
// Console.WriteLine();
// Console.WriteLine("What number do you want to see the price of?");
//
// int userInput = Convert.ToInt32(Console.ReadLine());
//
// switch (userInput)
// {
//     case 1:
//         Console.WriteLine("Rope costs 10 gold");
//         break;
//     case 2:
//         Console.WriteLine("Torches costs 15 gold");
//         break;
//     case 3:
//         Console.WriteLine("Climbing equipment costs 25 gold");
//         break;
//     case 4:
//         Console.WriteLine("Clean Water costs 1 gold");
//         break;
//     case 5:
//         Console.WriteLine("Machete costs 20 gold");
//         break;
//     case 6:
//         Console.WriteLine("Canoe costs 200 gold");
//         break;
//     case 7:
//         Console.WriteLine("Food Supplies cost 1 gold");
//         break;
//     default:
//         Console.WriteLine("Please enter a valid option");
//         break;
// }

// --- Discounted Inventory 


// Console.WriteLine("The following items are available:");
// Console.WriteLine("1 – Rope");
// Console.WriteLine("2 – Torches");
// Console.WriteLine("3 – Climbing Equipment");
// Console.WriteLine("4 – Clean Water");
// Console.WriteLine("5 – Machete");
// Console.WriteLine("6 – Canoe");
// Console.WriteLine("7 – Food Supplies");
// Console.WriteLine();
// Console.WriteLine("What number do you want to see the price of?");
//
// int userInputNum = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine("What's your name?");
//
// string userInputName = Console.ReadLine();
//
// string item = userInputNum switch
// {
//     1 => "Rope",
//     2 => "Torches",
//     3 => "Climbing Equipment",
//     4 => "Clean Water",
//     5 => "Machete",
//     6 => "Canoe",
//     7 => "Food Supplies",
// };
//
// int price = item switch
// {
//     "Rope" => 10,
//     "Torches" => 14,
//     "Climbing Equipment" => 20,
//     "Clean Water" => 6,
//     "Machete" => 18,
//     "Canoe" => 50,
//     "Food Supplies" => 16,
// };
//
// if (userInputName == "Ermak") price /= 2;
// Console.WriteLine($"{item} costs {price}");


// --- Multiply table

// int totalRows = 5;
// int totalColumns = 5;
//
// for (int currentRow = 1; currentRow <= totalRows; currentRow++)
// {
//     for (int currentColumn = 1; currentColumn <= totalColumns; currentColumn++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }


// --- The Prototype

// Console.WriteLine("User 1, enter a number between 0 and 100:");
// string user1_input = Console.ReadLine();
// int user1_num = Convert.ToInt32(user1_input);
//
// while (user1_num < 0 || user1_num > 100)
// {
//     Console.WriteLine("Enter a walid number between 0 and 100:");
//     user1_input = Console.ReadLine();
//     user1_num = Convert.ToInt32(user1_input);
// }
//
// Console.Clear();
//
// Console.WriteLine("User 2, guess the number.");
// string user2_input; // Объявляем здесь
// int user2_num; // Объявляем здесь
//
// while (true) // Используем цикл, из которого выйдем с помощью break
// {
//     user2_input = Console.ReadLine();
//     user2_num = Convert.ToInt32(user2_input);
//
//     if (user2_num == user1_num)
//     {
//         Console.WriteLine("You are right!");
//         break; // Выход из цикла, если число угадано
//     }
//     else if (user2_num > user1_num)
//     {
//         Console.WriteLine($"{user2_num} is too high!");
//         Console.WriteLine("What is your next guess?");
//     }
//     else // user2_num < user1_num
//     {
//         Console.WriteLine($"{user2_num} is too low!");
//         Console.WriteLine("What is your next guess?");
//     }
// }


// --- The Magic Cannon

// for (int shot = 1; shot <= 100; shot++)
// {
//     if (shot % 3 == 0 && shot % 5 == 0)
//     {
//         Console.ForegroundColor = ConsoleColor.Magenta;
//         Console.WriteLine($"{shot}. ULTRA BLAST!");
//         Console.ResetColor();
//     }
//     else if (shot % 3 == 0)
//     {
//         Console.ForegroundColor = ConsoleColor.Red;
//         Console.WriteLine($"{shot}. Fire blast!");
//         Console.ResetColor();
//     }
//     else if (shot % 5 == 0)
//     {
//         Console.ForegroundColor = ConsoleColor.Yellow;
//         Console.WriteLine($"{shot}. Electric blast!");
//         Console.ResetColor();
//     }
//     else
//     {
//         Console.ForegroundColor = ConsoleColor.White;
//         Console.WriteLine($"{shot}. Normal shot!");
//         Console.ResetColor();
//     }
// }


// --- Fill an array with '1' of based on user input value

// int length = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[length];
//
// for (int index = 0; index < array.Length; index++)
// {
//     array[index] = 1;
// }
//
// Console.WriteLine(array.Length);

// --- Smallest value in Array

// int[] array = new[] { 1, 2, -3, 4, 5, 6, -7, 8, 9, 10 };
// int smallestValue = int.MaxValue;
//
// for (int index = 0; index < array.Length; index++)
// {
//     if (array[index] < smallestValue)
//     {
//         smallestValue =  array[index];
//     }
// }
//
// Console.WriteLine(smallestValue);

// --- Average of the array

// int[] array = new[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
//
// int total = 0;
//
// for (int index = 0; index < array.Length; index++)
// {
//     total += array[index];
// }
//
// float average = Convert.ToSingle(total) / array.Length;
// Console.WriteLine(average);

// --- The Replicator of D'To

// int[] array = new int[5];
//
// Console.WriteLine("Enter 5 numbers to fill the array");
//
// for (int index = 0; index < array.Length; index++)
// {
//     int userInput = Convert.ToInt32(Console.ReadLine());
//     array[index] += userInput;
// }
//
// Console.WriteLine("First array:");
// for (int index = 0; index < array.Length; index++)
// {
//     Console.Write(array[index] + " "); // Выводим каждый элемент и пробел после него
// }
//
// Console.WriteLine();
//
// int[] newArray = array;
//
// Console.WriteLine("Second, copied array:");
//
// for (int index = 0; index < newArray.Length; index++)
// {
//     Console.Write(array[index] + " "); // Выводим каждый элемент и пробел после него
// }

// --- The Laws of Freach

// int[] array = new[] { 1, 2, -3, 4, 5, 6, -9, 8, 9, 10 };
// int smallestValue = int.MaxValue;
//
// foreach (int var in array)
// {
//     if (var < smallestValue)
//     {
//         smallestValue = var;
//     }    
// }
//
// Console.WriteLine(smallestValue);

// -----

// int[] array = new[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
//
// int total = 0;
// foreach (int number in array)
// {
//     total += number;
// }
//
// float average = Convert.ToSingle(total) / array.Length;
// Console.WriteLine(average);

// --- Looping through multi-dimensional array

// int[,] matrix = new int[4, 4];
//
// for (int row = 0; row < matrix.GetLength(0); row++)
// {
//     for (int column = 0; column < matrix.GetLength(1); column++)
//     {
//         Console.Write(matrix[column, row] + " ");
//     }
//
//     Console.WriteLine();
// }

// --- Void and return methods

// Console.WriteLine("What number should I count to?");
// int chosenNumber = ReadNumber();
// Console.WriteLine();
// Count(chosenNumber);
//
// void Count(int numberToCountTo)
// {
//     for (int current = 1; current <= numberToCountTo; current++)
//     {
//         Console.WriteLine(current);
//     }
// }
//
// int ReadNumber()
// {
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// --- Taking a number

// int result = AskForNumber("How long is your dick?");
// int rangeResult = AskForNumberInRange("Enter number between 0 and 100: ", 0, 100);
//
// int AskForNumber(string text)
// {
//     Console.WriteLine(text);
//     int responseNumber = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(responseNumber);
//     return responseNumber;
// }
//
// int AskForNumberInRange(string text, int min, int max)
// {
//     while (true)
//     {
//         int number = AskForNumber(text);
//         if (number >= min && number <= max)
//         {
//             return number;
//         }
//     }
// }

// --- Countdown

// int ReverseCount(int x)
// {
//     if (x < 1) return 1;
//     Console.WriteLine(x);
//     return ReverseCount(x - 1);
// }
//
// ReverseCount(11);


// ---  Hunting the Manticore

// int manticore_HP = 15;
// int consolas_HP = 10;
// int round = 1;
//
// // Получение начального расстония размещения Мантикоры от 1го пользователя
// int manticoreRange = AskForNumberInRange("Enter the distance to place Manticore ship form 0 to 100:", 0, 100);
// Console.Clear();
//
// Console.WriteLine("Player 2, it's your turn!");
//
//
// // --- Выполняющийся цикл игры пока ХП города или Mантикоры не упадет до 0
// while (consolas_HP > 0 && manticore_HP > 0)
// {
//     // Отображение статуса текущего Раунда
//     Console.WriteLine("-------------------");
//     DisplayStatus(round, consolas_HP, manticore_HP);
//
//     // Отображение ожидаемого урона
//     int damage = DamageForRound(round);
//     Console.ForegroundColor = ConsoleColor.Yellow;
//     Console.WriteLine($"The cannon is expected to deal {damage} damage this round");
//
//     // Получение расстояния выстрела от второго игрока
//     Console.ForegroundColor = ConsoleColor.White;
//     int fireRange = AskForNumber("Enter desired cannon range:");
//
//     // Отображение результата раунда
//     Console.ForegroundColor = ConsoleColor.Magenta;
//     DisplayOverOrUnder(fireRange, manticoreRange);
//
//     // Нанесение урона Мантикоре
//     if (fireRange == manticoreRange) manticore_HP -= damage;
//
//     // Нансение урона городу, если Мантикора жива
//     if (manticore_HP > 0) consolas_HP--;
//     
//     // Переход на следующий раунд
//     round++;
// }
//
// bool won = consolas_HP > 0;
// DisplayWinOrLose(won);
//
//
// // --- Methods
//
// // Выводит результат игры
// void DisplayWinOrLose(bool won)
// {
//     if (won)
//     {
//         Console.ForegroundColor = ConsoleColor.Green;
//         Console.WriteLine("The Manticore has been destroyed! The city is saved!");
//     }
//     else
//     {
//         Console.ForegroundColor = ConsoleColor.Red;
//         Console.WriteLine("The city is destroyed! The Manticore and Uncoded one won!");
//     }
// }
//
// // Выводит информацию о выстреле. Недолет, перелет или попадаение
// void DisplayOverOrUnder(int fireRange, int manticoreRange)
// {
//     if (fireRange < manticoreRange) Console.WriteLine("That round was a UNDERSHOOT of Manticore");
//     else if (fireRange > manticoreRange) Console.WriteLine("That round was a OVERSHOOT of Manticore");
//     else Console.WriteLine("That round was a DIRECT HIT");
// }
//
// int DamageForRound(int roundNumber)
// {
//     if (roundNumber % 3 == 0 && roundNumber % 5 == 0) return 10; // Fire-Electric Multi Blast!!
//     else if (roundNumber % 3 == 0) return 3; // Fire blast
//     else if (roundNumber % 5 == 0) return 3; // Electric blast
//     return 1; // Normal blast
// }
//
// void DisplayStatus(int round, int consolas_HP, int manticore_HP)
// {
//     Console.WriteLine($"Round: {round}, Consolas HP: {consolas_HP}/10, Manticore HP: {manticore_HP}/15");
// }
//
// // Получает от пользователя число с расстоянием размещения Мантикоры
// int AskForNumber(string text)
// {
//     Console.Write(text + " ");
//     Console.ForegroundColor = ConsoleColor.Cyan;
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }
//
// // Получает от пользователя число с расстоянием размещения Мантикоры
// // и проверяет условие вхождения в интервал
//
// int AskForNumberInRange(string text, int min, int max)
// {
//     while (true)
//     {
//         int number = AskForNumber(text);
//         if (number >= min && number <= max)
//         {
//             return number;
//         }
//     }
// }


// --- Simuls's Test

ChestState state = ChestState.Locked;

while (true)
{
    Console.WriteLine($"The chest is {state}. What do you want to do?:");
    string userInput = Console.ReadLine();

    switch (state)
    {
        case ChestState:
            state = 
        
    }
    
    // if (userInput == "unlock" && state == ChestState.Locked) state = ChestState.Unlocked;
    // else if (userInput == "")
    // else
    // {
    //     Console.WriteLine($"You cant {userInput} the chest because the chest is {state}!");
    // }
}

enum ChestState
{
    Locked,
    Unlocked,
    Closed,
    Open
}