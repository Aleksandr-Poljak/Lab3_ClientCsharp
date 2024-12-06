using System.Reflection;
using System;
using System.Runtime.InteropServices;

//Client for com server by Lab3 condition.

Type? typeObj= Type.GetTypeFromProgID("Lb34MyFn.1");
if(typeObj == null)
{
    Console.WriteLine("Ошибка получения типа!");
    return;
    
}
Console.WriteLine($"Объект {typeObj!.FullName} получен.");

dynamic? objFn = Activator.CreateInstance(typeObj);
if (objFn == null)
{
    Console.WriteLine("Ошибка создания объекта");
    return;
}

int num1 = 1;
int num2 = 2;
int num3 = 3;

double resultDouble = objFn.Fun141(num1, num2);
Console.WriteLine($"Результат вызова функции Fun141: {resultDouble}");

int resultInt = objFn.Fun142(num1, num2, num3);
Console.WriteLine($"Результат вызова функции Fun142: {resultInt}");

double num1In = 1.1;
double num2Out  = 2;

num2Out = objFn.Fun143(out num2Out);
Console.WriteLine($"Результат вызова функции Fun143: {num2Out}");
