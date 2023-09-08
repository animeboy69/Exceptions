namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float myFloat = 55.5f;
            float myOtherFloat = 0.0f;
            float result = 0f;

            Random rand = new Random();
            int myInt = rand.Next(3, 29);

            try
            {
                result = Divide(myFloat, myOtherFloat);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a number other than zero.");
                myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());

                try
                {
                    result = Divide(myFloat, myOtherFloat);
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message);
                }
                finally
                {
                    Console.WriteLine("Calculations completed with a result of " + result);
                }
            }

            try
            {
                CheckAge(myInt);
            }catch (Exception e)
            {
                Console.WriteLine($"You are {myInt}, you are not old enough!");
            }
        }




        /// <summary>
        /// This is Declare that float is called result 
        /// </summary>
        /// <param name="x">Trying to Divide the method</param>
        /// <param name="y">This is returning the two numbers</param>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException"></exception>
        static float Divide(float x, float y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return x / y;
            }
        }
        /// <summary>
        /// This is checking the users age if they can play that game 
        /// </summary>
        /// <param name="age"> Tells the users age </param>
        /// <exception cref="ArgumentException"></exception>
        static void CheckAge(int age)
        {
            if (age > 17)
            {
                Console.WriteLine($"You are {age}, you can play mature games!");
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}


