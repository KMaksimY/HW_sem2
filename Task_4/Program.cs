﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

using System;

class Program {
    static void Main(string[] args) {
      Console.WriteLine("Put one number");

      int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
      
      for (int i=2; i<=N; i=i+2){
                   
          
          Console.WriteLine(i);
      }
    }
}

