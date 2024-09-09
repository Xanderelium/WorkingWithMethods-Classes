namespace WorkingWithMethods_Classes
{
    internal class Program
    {
        static void SwappingIntegers(int a, int b)
        {
            int x;
            Console.WriteLine($"You wrote {a} and {b}");
            x = a;
            a = b;
            b = x;
            Console.WriteLine($"Now its {a} and {b}");
        }
        static void CountArrayElements(int[] numberArray)
        {
            int total = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {

                total += numberArray[i];
                //Console.WriteLine(numberArray[0] + numberArray[1] + numberArray[2] + numberArray[3] + numberArray[4]);
            }
            Console.WriteLine(total);
        }
        static int HowManyLetters(string word)
        {
            int letterCount = word.Length;
            return letterCount;

        }
        static void Greetings()
        {
            Console.WriteLine("Welcome friends! \nHave a nice day!");
        }

        static void Greetings(string name)
        {
            Console.WriteLine($"Welcome friend {name} !\r\nHave a nice day!");
        }

        static int AddingIntegers(int number1, int number2)
        {
            return number1 + number2;
        }
        static void Main(string[] args)
        {
            Car myFirstCar = new Car();
            Car mySecondCar = new Car();

            myFirstCar.NameOfCar = "Honda";
            myFirstCar.nameOfYear = "1994";
            myFirstCar.nameOfModel = "NSX";
            myFirstCar.nameOfColor = "Red";
            myFirstCar.CurrentSpeed = 0;
            myFirstCar.maxSpeed = 300;
            myFirstCar.minSpeed = 0;

            mySecondCar.NameOfCar = "Toyota";



            Console.WriteLine($"{myFirstCar.NameOfCar}, is driving, broom broom, it was made back in {myFirstCar.nameOfYear} with a model name of {myFirstCar.nameOfModel} in a very beautiful " +
                $"bright {myFirstCar.nameOfColor}");

            Console.ReadKey();
            {
                myFirstCar.GoFaster(ref myFirstCar.CurrentSpeed);



                Console.WriteLine(myFirstCar.CurrentSpeed);

                myFirstCar.GoSlower(ref myFirstCar.CurrentSpeed);
                Console.ReadKey();
                //myFirstCar.GoSlower(ref myFirstCar.speed);

                CarOwner John = new CarOwner();

                John.Cars.Add(myFirstCar);
                John.Cars.Add(mySecondCar);
                Console.WriteLine(John.Cars.Count);


                for (int i = 0; i < John.Cars.Count; i++)
                {
                    Console.WriteLine(John.Cars[i]);
                }

                Console.WriteLine("\n" + John.Cars[0]);

                Console.WriteLine(myFirstCar);

                Console.ReadKey();

            }
        }
    }
    public class CarOwner
    {
        public string Name = "";
        public List<Car> Cars = new List<Car>();
    }
    public class Msg
    {

        public static void DisplayMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    public class Car
    {
        public override string ToString()
        {
            return $"{NameOfCar} {nameOfModel}";
        }

        public string NameOfCar = "";
        public string nameOfColor = "";
        public string nameOfModel = "";
        public string nameOfYear = "";
        public int CurrentSpeed = 0;
        public int maxSpeed = 0;
        public int minSpeed = 0;


        public void GoFaster(ref int speed)
        {
            while (speed != maxSpeed)
            {
                speed++;
                Console.Write(speed + " km/h ");

            }
            //Console.WriteLine($"\nYour car is going {speed} km/h");
            //return speed;
        }

        public void GoSlower(ref int speed)
        {

            while (speed != minSpeed)
            {
                speed--;
                Console.Write(speed + " km/h ");

            }
            Console.WriteLine($"\nYour car is going {speed}");
        }
    }
    class HTML
    {
        public void DisplayHTML(string html)
        {
            //adding a comment
            Console.WriteLine("<!DOCTYPE html >\n < html >\n < body >\n < h1 > Välkomna! </ h1 >\r\n < p > Kurs om C#</p>\r\n<p>Kurs om Databaser</p>" +
            "\r\n<p>Kurs om Webbutveckling</p>\r\n<p>Kurs om Clean code</p>\r\n</body>\r\n</html>");
        }
    }
}
