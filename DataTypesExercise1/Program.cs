// Problem 1.
// Values
// b52130, -115, 4825932, 97, -10000


//ushort a = 52130;
//sbyte b = -115;
//long c = 4825932;
//sbyte d = 97;
//short e = -10000;

//Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n",a,b,c,d,e);

// Problem 2.

// 34.567839023, 12.345, 8923.1234857, 3456.091

//double a = 34.567839023;
//float b = 12.345f;
//double c = 8923.1234857;
//float d = 3456.091f;

//Console.WriteLine($"{a}  {b}  {c}  {d}");

// Problem 3.

//int a = 0XFE;
//Console.WriteLine(a);

//Problem 4.

//char a = '\u002A';
//Console.WriteLine(a);

//Problem 5.

//bool isFemale = true;
//Console.WriteLine(isFemale);

//Problem 6.

//string a = "Hello";
//string b = "World";
//object c = a + " "+b;
//string d = (string) c;
//Console.WriteLine(d);

//Problem 7.

//string quotation = "The \"use\" of quotations causes difficulties.";
//string str = @"The ""use"" of quotations causes difficulties.";
//Console.WriteLine(str);
//Console.WriteLine(quotation);

//Problem 8.

//char a = '\u00A9';
//Console.WriteLine($"   {a}\n");
//Console.WriteLine($"  {a} {a}\n");
//Console.WriteLine($" {a}   {a}\n");
//Console.WriteLine($"{a} {a} {a} {a}"); 


//Problem 9.

//int a = 139;
//int b = 27;
//Console.WriteLine($"Before:\n a={a}\n b={b}");
//int c = a;
//a=b; b=c;
//Console.WriteLine($"After:\na={a}\n b={b}");

//Problem 10.
//● First name
//● Last name
//● Age (0...100)
//● Gender (m or f)
//● Personal ID number (e.g. 8306112507)
//● Unique employee number (27560000...27569999)

//string firstName = "Amanda";
//string lastName = "Jonson";
//int age = 27;
//char gender = 'F';
//long personalId = 8306112507;
//long uniqueEmployeeNo = 27563571;

//Console.WriteLine(
//    $@"First Name: {firstName}
//Last Name: {lastName}
//Age: {age}
//Gender: {gender}
//Personal Id: {personalId}
//Unique Employee number: {uniqueEmployeeNo}");

//Problem 11.

//string firstName = "Iulia";
//string middleName = "Miriam";
//string lastName = "Muresan";
//double balance = 8565215;
//string currency = "EUR";
//string bankName = "Banca Transilvania";
//string iban = "RO89BTRLRONCRT5697841XX";
//string[] cardNumbers = [
//    "5655 4411 0000 8974",
//    "4487 5596 2222 1111",
//    "5555 8888 7777 9999"];

//Console.WriteLine(
//    $@"First Name: {firstName} {middleName}
//Last Name: {lastName}
//Balance: {balance} {currency}
//Bank Name: {bankName}
//IBAN: {iban}
//Card Numbers: {string.Join(",\n", cardNumbers)}");

//Problem 12.
//int? x = null;
//double? y = null;
//Console.WriteLine($"x= {x}, y= {y}");
//x += 6;
//y += 5;
//Console.WriteLine($"x= {x}, y= {y}");

//Problem 13.

//const double eps = 0.000001;
//double a = 0;
//double b = 0;
//double dist = 0;

//Console.Write("a= ");
//string? valueA = Console.ReadLine();

//Console.Write("b= ");
//string? valueB = Console.ReadLine();

//if (!double.TryParse(valueA,out a))
//{
//    Console.WriteLine("The value of a is not of type double.");
//}

//if (!double.TryParse(valueB, out b))
//{
//    Console.WriteLine("The value of b is not of type double.");
//}

//if (a>b)
//{
//    dist = a - b;
//    Console.WriteLine(dist < eps);
//}

//if (b>a)
//{
//    dist = b - a;
//    Console.WriteLine(dist < eps);
//}

//if (a == b)
//{
//    Console.WriteLine(true);
//}

// Problem 14.

//for (char c = '\u0000'; c <= '\u00ff'; c++)
//{
//    Console.WriteLine(c);
//}

//Problem 15.

//const int noOfWeekends = 52;
//double noOfMatches = 0;

//bool isLeapYear = Console.ReadLine() == "t";
//if (isLeapYear)
//{
//    noOfMatches = 3;
//}

//string p = Console.ReadLine() ?? "0";
//noOfMatches += int.Parse(p) / 2.0;

//string h = Console.ReadLine() ?? "0";
//int homeTownWeekends = int.Parse(h);
//noOfMatches += homeTownWeekends;

//noOfMatches += 2.0 / 3.0 * (noOfWeekends-homeTownWeekends);

//Console.WriteLine((int)noOfMatches);