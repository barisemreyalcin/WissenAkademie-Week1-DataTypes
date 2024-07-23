// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!")

// Variables: İçinde değer tutan bellekte bulunan depolardır.
// Tutulacak değere uygun veri tipi seçilmelidir. Plakalar için byte yeterlidir mesela
// String "" arasına yazılır. Sınırsız değer tutacağı için başlangıç olarak "" tanımlanmalıdır. (Kaynak yönetimi açısınddan önemli)

//char karakter = 'b'; // Tek tırnak

//Console.WriteLine("Hi");
//Console.WriteLine('A');
//Console.WriteLine(24); // Console.WriteLine() methodu içerisinde tam sayısal verileri  yazarken byte, sbyte, short, ushort vs veri tiplerindeki değerler int olarak algılanır.

// Herhangi bir harf belirtilmeze ondalıklılar double olarak algılanır:
//Console.WriteLine(17.6); // ddouble algılanır
//Console.WriteLine(17.6d); // d veya D ile double
//Console.WriteLine(17.6f); // f veya F ile float
//Console.WriteLine(17.6m); // m veya M ile decimal

// Tam sayısal veri tiplerinin değer aralıklarına ulaşabiliriz:
//Console.WriteLine("Int min val: " + int.MinValue);
//Console.WriteLine("Int max val: " + int.MaxValue);
//int sayi = 2147483648; // hatalı olacaktır. Bu değer fazla, long ile tanımlarsan doğru olur.

// Value Type
/*
 Bu veri tipleri stack'te tutulur
 Verilen değerin kendisini tutar. 5 -> 00000101
 Bu tiplerde değişkenler arası kopyalama yapılırsa verinin kendisi kopyalanır
 */

//int sayi1 = 10;
//int sayi2 = 25;
//int sayi3 = sayi2;
//sayi1 = 5 + sayi3;
//int sayi4 = sayi1;
//sayi2 = sayi4;
//Console.WriteLine("Sayı 1: " + sayi1);
//Console.WriteLine("Sayı 2: " + sayi2);
//Console.WriteLine("Sayı 3: " + sayi3);
//Console.WriteLine("Sayı 4: " + sayi4);

// Reference Type
/*
 Bu veri tipleri RAM'in heap bölümünde tutulur. Verilere erişmek için stack'teki adresleri kullanılır
 string(farklı davranır), class, array, collection
 */

//string text1 = "Barış Emre";
//string text2 = string.Empty;

//text2 = text1;

//Console.WriteLine("Text 1: " + text1);
//Console.WriteLine("Text 2: " + text2);
//Console.WriteLine("Text 1 bellek adresi: " + text1.GetHashCode());
//Console.WriteLine("Text 2 bellek adresi: " + text2.GetHashCode());

//text1 = "Test";

//Console.WriteLine("Text 1: " + text1);
//Console.WriteLine("Text 2: " + text2);
//Console.WriteLine("Text 1 bellek adresi: " + text1.GetHashCode());
//Console.WriteLine("Text 2 bellek adresi: " + text2.GetHashCode());

//using DataTypes;

//Person baris = new Person();
//baris.age = 27;

//Person enes = new Person();
//enes.age = 21;

//Person mustafa = new Person();
//mustafa.age = 30;

//Console.WriteLine("Baris age: " + baris.age);
//Console.WriteLine("Enes age: " + enes.age);
//Console.WriteLine("Mustafa age: " + mustafa.age);

//Console.WriteLine("Baris bellek adresi: " + baris.GetHashCode());
//Console.WriteLine("Enes bellek adresi: " + enes.GetHashCode());
//Console.WriteLine("Mustafa bellek adresi: " + mustafa.GetHashCode());

//baris.age = mustafa.age;
//mustafa.age = 32;

//Console.WriteLine("Baris age: " + baris.age);
//Console.WriteLine("Enes age: " + enes.age);
//Console.WriteLine("Mustafa age: " + mustafa.age);

//Console.WriteLine("Baris bellek adresi: " + baris.GetHashCode());
//Console.WriteLine("Enes bellek adresi: " + enes.GetHashCode());
//Console.WriteLine("Mustafa bellek adresi: " + mustafa.GetHashCode());  

#region Girilen Sayının Karesi ve Küpü
//int sayi = 0;
//long kare = 0;
//long kup = 0;

//Console.Write("Karesini ve küpünü hesaplamak istediğiniz sayıyı giriniz: ");
//sayi = int.Parse(Console.ReadLine()); // parse ederiz çünkü ReadLine string döndürür

//kare = sayi * sayi;
//kup = kare * sayi; // sayi * sayi * sayi

//Console.WriteLine($"Girdiğiniz sayının karesi: {kare}");
//Console.WriteLine($"Girdiğiniz sayının küpü: {kup}");
#endregion

#region Dört İşlem
//int sayi1, sayi2;
//char islem; // + - * /
//string mesaj = string.Empty;
//int sonuc = 0;

//Console.Write("Yapılacak işlemi giriniz [+ | - | * | /]: ");
//islem = char.Parse(Console.ReadLine());
//bool islemSonuc = (islem == '+' || islem =='-' || islem == '*' || islem == '/');
//mesaj = (!islemSonuc ? "Yanlış işlem seçtiniz" : "Doğru bir işlem seçtiniz"); // ternary operator

//if (!islemSonuc) goto IslemYanlisSecildi;
//else goto IslemSonuc;

//IslemYanlisSecildi:
//Console.WriteLine(mesaj);
//Console.ReadLine();
//Environment.Exit(0);

//IslemSonuc:
//Console.Write("1. sayıyı giriniz: ");
//sayi1 = int.Parse(Console.ReadLine());
//Console.Write("2. sayıyı giriniz: ");
//sayi2 = int.Parse(Console.ReadLine());
//sonuc = (islem == '+' ? sayi1 + sayi2 : (islem == '-' ? sayi1 - sayi2 : (islem == '*' ? sayi1 * sayi2 : sayi1 /sayi2)));
//Console.WriteLine(mesaj);
//Console.WriteLine(sonuc);

/*
 AND &&
 OR ||
 NOT !
 */
#endregion

#region Tip Dönüşümleri
//int num1= 255;
//byte convertedNum1 = (byte)num1; // taşıyabileceği kadarını taşımaya çalışır
//Console.WriteLine(convertedNum1);

//bool dogruMu = true;
//Console.WriteLine(dogruMu);
//Console.WriteLine(dogruMu.ToString());
//Console.WriteLine(Convert.ToByte(dogruMu));
//Console.WriteLine(Convert.ToInt32(dogruMu));
//Console.WriteLine(Convert.ToDouble(dogruMu));  
//Console.WriteLine(Convert.ToInt64(dogruMu));

//string sayi = "2000";
//short shortSayi = Convert.ToInt16(sayi);
//int intSayi = Convert.ToInt32(sayi);
//long longSayi = Convert.ToInt64(sayi);

//Console.WriteLine(shortSayi);
//Console.WriteLine(intSayi);
//Console.WriteLine(longSayi)

//string sayi = "100,75";
//float sayiFloat = Convert.ToSingle(sayi);
//double sayiDouble = Convert.ToDouble(sayi);
//decimal sayiDecimal = Convert.ToDecimal(sayi);


//Console.WriteLine(sayiFloat);
//Console.WriteLine(sayiDouble);
//Console.WriteLine(sayiDecimal);
#endregion