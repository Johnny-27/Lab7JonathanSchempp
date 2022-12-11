//Conversions
bool convert = true;
while (convert == true)
{
    void CelsiusToFahrenheit()
    {
        double fahrenheit;
        Console.WriteLine("Pick a number in Celsius");
        double answer = Convert.ToDouble(Console.ReadLine());
        double celsius = answer;
        fahrenheit = (answer * 9) / 5 + 32;
        Console.WriteLine("Celsius: " + answer);
        Console.WriteLine("Fahrenheit: " + fahrenheit);
        Console.ReadLine();
        (int celsius, int fahrenheit) CelsiusToFahrenheit = (1, 36);
    }

Console.WriteLine("Enter your desired conversion");
Console.WriteLine("1:Celsius To Fahrenheit");
Console.WriteLine("2:Celsius To Kelvin");
Console.WriteLine("3:Fahrenheit To Celsius");
Console.WriteLine("4:Fahrenheit To Kelvin");
Console.WriteLine("5:Kelvin To Celsius");
Console.WriteLine("6:Kelvin To Fahrenheit");
Console.WriteLine("7:Inches To Feet");
Console.WriteLine("8:Inches To Yards");
Console.WriteLine("9:Feet To Inches");
Console.WriteLine("10:Feet To Yards");
Console.WriteLine("11:Yards To Inch");
Console.WriteLine("12:Yards To Feet");
Console.WriteLine("13:Seconds To Minutes");
Console.WriteLine("14:Seconds To Hours");
Console.WriteLine("15:Minutes To Seconds");
Console.WriteLine("16:Minutes To Hours");
Console.WriteLine("17:Hours To Seconds");
Console.WriteLine("18:Hours To Minutes");
Console.WriteLine("19: Exit");

int changeTo = int.Parse(Console.ReadLine());
if (changeTo == 1) CelsiusToFahrenheit();
if (changeTo == 19)
    {
        convert = false;
    }
    void CelsiusToKelvin()
    {
        double Kelvin;
        Console.WriteLine("Enter your degrees in Celsius");
        double answer = Convert.ToDouble(Console.ReadLine());
        double celsius = answer;
        Kelvin = (answer + 273.15);
        Console.WriteLine("Celsius: " + answer);
        Console.WriteLine("Kelvin: " + Kelvin);
        Console.ReadLine();
        (int celsius, int Kelvin) CelsiusToKelvin = (1, 36);
    }

    if (changeTo == 2) CelsiusToKelvin();

    void FahrenheitToCelsius()
    {
        double celsius;
        Console.WriteLine("Enter your degrees in Fahrenheit");
        double answer = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = answer;
        celsius = (answer - 32) * 5 / 9;
        Console.WriteLine("Fahrenheit: " + answer);
        Console.WriteLine("Celsius: " + celsius);
        Console.ReadLine();
        (int fahrenheit, int celsius) FahrenheitToCelsius = (1, -17);
    }

    if (changeTo == 3) FahrenheitToCelsius();
    void FahrenheitToKelvin()
    {
        double Kelvin;
        Console.WriteLine("Enter your degrees in Fahrenheit");
        double answer = Convert.ToDouble(Console.ReadLine());
        double Fahrenheit = answer;
        Kelvin = (((answer - 32) * 5) / 9) + 273.15;
        Console.WriteLine("Fahrenheit: " + answer);
        Console.WriteLine("Kelvin: " + Kelvin);
        Console.ReadLine();
        (int Fahrenheit, int Kelvin) FahrenheitToKelvin = (1, 255);
    }

    if (changeTo == 4) FahrenheitToKelvin();
    void KelvinToCelsius()
    {
        double celsius;
        Console.WriteLine("Enter your degrees in Kelvin");
        double answer = Convert.ToDouble(Console.ReadLine());
        double Kelvin = answer;
        celsius = (answer - 273.15);
        Console.WriteLine("Kelvin: " + answer);
        Console.WriteLine("celsius: " + celsius);
        Console.ReadLine();
        (int Kelvin, int celsius) KelvinToCelsius = (1, -272);
    }

    if (changeTo == 5) KelvinToCelsius();
    void KelvinToFahrenheit()
    {
        double fahrenheit;
        Console.WriteLine("Enter your degrees in Kelvin");
        double answer = Convert.ToDouble(Console.ReadLine());
        double Kelvin = answer;
        fahrenheit = (((answer - 273.15) * 9) / 5) + 32;
        Console.WriteLine("Kelvin: " + answer);
        Console.WriteLine("Fahrenheit: " + fahrenheit);
        Console.ReadLine();
        (int Kelvin, int fahrenheit) KelvinToFahrenheit = (1, -457);
    }

    if (changeTo == 6) KelvinToFahrenheit();
    void InchToFeet()
    {
        double Feet;
        Console.WriteLine("Enter your length in Inches");
        double answer = Convert.ToDouble(Console.ReadLine());
        double Inch = answer;
        Feet = (answer / 12);
        Console.WriteLine("Inch: " + answer);
        Console.WriteLine("Feet: " + Feet);
        Console.ReadLine();
        (int Inch, int Feet) InchToFeet = (12, 1);
    }

    if (changeTo == 7) InchToFeet();
    void InchToYard()
    {
        double Yard;
        Console.WriteLine("Enter your length in Inches");
        double answer = Convert.ToDouble(Console.ReadLine());
        double Inch = answer;
        Yard = (answer / 36);
        Console.WriteLine("Inch: " + answer);
        Console.WriteLine("Yard: " + Yard);
        Console.ReadLine();
        (int Inch, int Yard) InchToYard = (36, 1);
    }

    if (changeTo == 8) InchToYard();
    void FeetToInch()
    {
        double Inch;
        Console.WriteLine("Enter your length in Feet");
        double answer = Convert.ToDouble(Console.ReadLine());
        double Feet = answer;
        Inch = (answer * 12);
        Console.WriteLine("Feet: " + answer);
        Console.WriteLine("Inch: " + Inch);
        Console.ReadLine();
        (int Feet, int Inch) FeetToInch = (1, 12);
    }

    if (changeTo == 9) FeetToInch();
    void FeetToYard()
    {
        double Yard;
        Console.WriteLine("Enter your length in Feet");
        double answer = Convert.ToDouble(Console.ReadLine());
        double Feet = answer;
        Yard = (answer / 3);
        Console.WriteLine("Feet: " + answer);
        Console.WriteLine("Yard: " + Yard);
        Console.ReadLine();
        (int Feet, int Yard) FeetToYard = (3, 1);
    }

    if (changeTo == 10) FeetToYard();
    void YardToInch()
    {
        double Inch;
        Console.WriteLine("Enter your length in Yards");
        double answer = Convert.ToDouble(Console.ReadLine());
        double Yard = answer;
        Inch = (answer * 36);
        Console.WriteLine("Yard: " + answer);
        Console.WriteLine("Inch: " + Inch);
        Console.ReadLine();
        (int Yard, int Inch) YardToInch = (1, 36);
    }

    if (changeTo == 11) YardToInch();
    void YardToFeet()
    {
        double Feet;
        Console.WriteLine("Enter your length in  Yards");
        double answer = Convert.ToDouble(Console.ReadLine());
        double Yard = answer;
        Feet = (answer * 3);
        Console.WriteLine("Yard: " + answer);
        Console.WriteLine("Feet: " + Feet);
        Console.ReadLine();
        (int Yard, int Feet) YardToFeet = (1, 3);
    }

    if (changeTo == 12) YardToFeet();
    void SecondsToMinutes()
    {
        double minutes;
        Console.WriteLine("Enter your time in Seconds");
        double answer = Convert.ToDouble(Console.ReadLine());
        double Seconds = answer;
        minutes = (answer / 60);
        Console.WriteLine("Seconds: " + answer);
        Console.WriteLine("Minutes: " + minutes);
        Console.ReadLine();
        (int Seconds, int Minutes) SecondsToMinutes = (60, 1);
    }

    if (changeTo == 13) SecondsToMinutes();
    void SecondsToHours()
    {
        double Hours;
        Console.WriteLine("Enter your time in Seconds");
        double answer = Convert.ToDouble(Console.ReadLine());
        double Seconds = answer;
        Hours = (answer / 3600);
        Console.WriteLine("Seconds: " + answer);
        Console.WriteLine("Hours: " + Hours);
        Console.ReadLine();
        (int Seconds, int Hours) SecondsToHours = (3600, 1);
    }

    if (changeTo == 14) SecondsToHours();
    void MinutesToSeconds()
    {
        double Seconds;
        Console.WriteLine("Enter your time in Minutes");
        double answer = Convert.ToDouble(Console.ReadLine());
        double Minutes = answer;
        Seconds = (answer * 60);
        Console.WriteLine("Minutes: " + answer);
        Console.WriteLine("Seconds: " + Seconds);
        Console.ReadLine();
        (int Minutes, int Seconds) MinutesToSeconds = (1, 60);
    }

    if (changeTo == 15) MinutesToSeconds();
    void MinutesToHours()
    {
        double Hours;
        Console.WriteLine("Enter your time in Minutes");
        double answer = Convert.ToDouble(Console.ReadLine());
        double Minutes = answer;
        Hours = (answer / 60);
        Console.WriteLine("Minutes: " + answer);
        Console.WriteLine("Hours: " + Hours);
        Console.ReadLine();
        (int Minutes, int Hours) MinutesToHours = (60, 1);
    }

    if (changeTo == 16) MinutesToHours();
    void HoursToSeconds()
    {
        double Seconds;
        Console.WriteLine("Enter your time in Hours");
        double answer = Convert.ToDouble(Console.ReadLine());
        double Hours = answer;
        Seconds = (answer * 3600);
        Console.WriteLine("Hours: " + answer);
        Console.WriteLine("Seconds: " + Seconds);
        Console.ReadLine();
        (int Hours, int Seconds) HoursToSeconds = (1, 3600);
    }

    if (changeTo == 17) HoursToSeconds();
    void HoursToMinutes()
    {
        double Minutes;
        Console.WriteLine("Pick a number in Hours");
        double answer = Convert.ToDouble(Console.ReadLine());
        double Hours = answer;
        Minutes = (answer * 60);
        Console.WriteLine("Hours: " + answer);
        Console.WriteLine("Minutes: " + Minutes);
        Console.ReadLine();
        (int Hours, int Minutes) HoursToMinutes = (1, 60);
    }

    if (changeTo == 18) HoursToMinutes();
}

enum Tempature { Celsius, Fahrenheit, Kelvin }
enum Length { Inch, Feet, Yard }
enum Time { Seconds, Minutes, Hours }