﻿using class_and_object;

internal class Program
{
    private static void Main(string[] args)
    {
        prgrammer std3 = new prgrammer();
        calcolatefac();
        studDetials();
        std3.learn();
    }

    static void studDetials()
    {
        prgrammer std2 = new prgrammer();
        std2.id = 435632;
        std2.name = "lola";
        std2.grade = 'D';



        Console.WriteLine($"the student with id " +
            $"'{std2.id}' and name '{std2.name}' " +
            $"has  '{std2.grade}' as a grade");
        

    }

    static void calcolatefac()
    {
        int fac1 = 1;
        for (int i = 6; i > 1; i--)
        {
            fac1 = fac1 * i;
        }
        Console.WriteLine(fac1);
    }
}