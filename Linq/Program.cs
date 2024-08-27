using Linq;
using System.ComponentModel.DataAnnotations;


List<int> numbers = new List<int>();
{}
//10 elemanlı random liste oluşturmak
for (int i = 0;i<10;i++)
{
    Random rnd = new Random();
    int randomnumber = rnd.Next(-50,50);
    numbers.Add(randomnumber);
}
Console.WriteLine("Liste");
foreach (var num in numbers)
{
    Console.WriteLine(num);
}

Console.WriteLine("Çift sayılar ");


//çift olan sayılar 

var evenNumber = numbers.Where(num => num %2 == 0) ;

foreach (var num in evenNumber)
{
    Console.WriteLine(num);
}


Console.WriteLine("Tek sayılar ");
//tek olan sayılar 

var oddNumber = numbers.Where(num => num % 2 == 1);
foreach (var num in oddNumber)
{

Console.WriteLine(num); 
}

Console.WriteLine("Negatif sayılar ");
//negatif sayılar 
var negatifNumber = numbers.Where(num => num < 0);

foreach (var num in negatifNumber)
{

Console.WriteLine(num); 
}

Console.WriteLine("Pozitif sayılar");
//pozitif sayılar

var pozitifNumber= numbers.Where(num => num > 0);

foreach (var num in pozitifNumber)
{
    Console.WriteLine(num);
}

Console.WriteLine("15'ten büyük 22'den küçük olan sayılar ");
//aralıktaki sayıları yazdırmak

var limitNumber =numbers.Where(num => (num <22)&(num>15));

foreach (var num in limitNumber)
{
    Console.WriteLine(num);
}

Console.WriteLine("Listedeki sayıların karesi");
//sayıların karesi
var squareNumber = numbers.Select(num => num * num);

foreach (var num in squareNumber)
{
Console.WriteLine(num); 
}