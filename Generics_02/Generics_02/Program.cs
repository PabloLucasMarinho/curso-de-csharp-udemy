﻿using System.Globalization;
using Generics_02.Entities;
using Generics_02.Services;

List<Product> list = [];

Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] vect = Console.ReadLine().Split(',');
    string name = vect[0];
    double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
    list.Add(new Product(name, price));
}

CalculationService calculationService = new();

Product max = calculationService.Max(list);

Console.WriteLine("Max: ");
Console.WriteLine(max);