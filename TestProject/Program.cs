using System;
using System.ComponentModel.DataAnnotations;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomGenerator = new RandomGenerator();
            var number = randomGenerator.RandomNumber(10000, 20000);
            var randomString = randomGenerator.RandomString(100);
            var password = randomGenerator.RandomPassword();

            var alphaNumericString = randomGenerator.RandomString(100, "0123456789ABCDEFGHIJKLMNOPQSTUVWXYZabcdefghijklmnopqrstuvwxyz");

            Console.WriteLine(number);
            Console.WriteLine(randomString);
            Console.WriteLine(password);
            Console.WriteLine("AlphaNumericString :{0}", alphaNumericString);
        }
    }
}