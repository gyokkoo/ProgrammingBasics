using System;
/*
The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given
 weight on the Earth. 
Examples:
weight	weight on the Moon
86	    14.62
74.6	12.682
53.7	9.129
 */
class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Please enter your weight to see how much you will weight on the Moon");
        double weightOnTheEarth = double.Parse(Console.ReadLine());
        double weightOnTheMoon = weightOnTheEarth * 0.17;
        Console.WriteLine("Your weight on the Earth is: {0}", weightOnTheEarth);
        Console.WriteLine("Your weight on the Moon will be: {0}", weightOnTheMoon);
    }
}

