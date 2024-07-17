Console.WriteLine("Rüya Manavına Hoş Geldiniz!");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diğer bütün meyveler 4 TL");
Console.WriteLine(" ");
Console.Write("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer): ");
string meyve = Console.ReadLine().ToLower();   // Burada .ToLower() kullanarak girilen string ifadenin harflerini küçültüldü. Bu şekilde büyük küçük harf duyarlılığı ortadan kaldırıldı.

// if-else karar yapısıyla

if (meyve == "elma")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
}
else if (meyve == "armut")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
}
else if (meyve == "çilek")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
}
else if (meyve == "muz")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
}
else
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
}



// switch-case karar yapısıyla

switch (meyve)
{
    case "elma":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
        break;
    case "armut":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
        break;
    case "çilek":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
        break;
    case "muz":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
        break;
    default:
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
        break;

}

//Bu projeyi switch - case yapısıyla yapmak daha mantıklı çünkü : 
// 1 - Switch - case karar yapısıyla bu proje çok daha okunabilir olur.
// 2 - Sadece string ifadelerle eşleşme yapılıyor
// 3 - Herhangi bir operatör kullanmaya gerek yok