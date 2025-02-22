using System;
using static System.Console;

// 1. Doira yuzi va aylana uzunligini hisoblash

// Console dan raduisni qiymatini oling va erkanga doiraning yuzi (S=pi*radius^2) va 
// aylana uzunligini (L=2*pi*radius) erkanga chiqaring.
// Input: radius=3
// Output: S=28.2743338823081, L=18.8495559215388
// --------------
// Input: radius=4.23
// Output: S=56.2122031914168, L=26.5778738493697

WriteLine("====== 1-Masala ======");
Write("Radiusni kiriting: ");
double radius = Convert.ToDouble(ReadLine());

// double pi = 3.14;
double pi = Math.PI;
double S = pi * (radius * radius); // S = pi * rad^2 
double L = 2 * pi * radius; // L = 2pr
WriteLine($"Yuzi: {S} , aylana uzunligi {L}");




// 2. Valyuta konvertri

// Bir valyutadagi summani sumga aylantiruvchi dastur tuzing. Summa va valyuta kursini 
// e’lon qiling va konvertatsiya qilingan summani hisoblang. Natijani ekranga chiqaring.
// Input: qiymat=2, kurs=12400 so’m
// Output: 24800 so’m
// ----------------
// Input: qiymat=7.6, kurs=12400 so’m
// Output: 94240 so’m

WriteLine("\n====== 2-Masala ======");

Write("Miqdorni kiriting: ");
double qiymay =  Convert.ToDouble(ReadLine());

WriteLine("Valyuta kursini kiriting: ");
double kurs = Convert.ToDouble(ReadLine());

double sum = qiymay * kurs;

WriteLine($"Konvertatsiya qilingan summa: {sum} so'm");


// 3. Yoshni hisoblash

// Foydalanuvchining tug’ilgan yilini (int x) consoledan oling. Uning yoshini kunlarda 
// ifodalang. Kabisa yilini hisobga olmang
// Input: x=2004
// Output: 6935  ======== bu javob 2023 yil miqiyosida qaytar ekan
// -----------------
// Input: x= 1996
// Output: 9855 ======== bu javob 2023 yil miqiyosida qaytar ekan

WriteLine("\n====== 3-Masala ======");
Write("Tug'ilgan yilingizni kiriting: ");
int x = Convert.ToInt32(ReadLine());

Write("Xozirgi yilni kiriting: ");
int currentlyYear = Convert.ToInt32(ReadLine());
int ageInYears = currentlyYear - x;
int ageInDays = ageInYears * 365;

WriteLine($"Siz taxminan {ageInDays} kun yashagansiz.");