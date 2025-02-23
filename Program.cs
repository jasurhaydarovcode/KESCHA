using System;
using static System.Console;

// 1. Kalkulyator:
// Foydalanuvchidan ikkita raqam va operatsiyani (+, -, *, /) so'raydigan kalkulyator dasturini yozing va keyin operatsiya natijasini chop eting.
// Input = 5;
// Input = +;
// Input = 5;
// Output = 10;

WriteLine("====== 1-Masala ======");
Write("Enter the first number: ");
double firstNumber = Convert.ToDouble(ReadLine());

Write("Iltimos ishorani tanlang: +, -, *, / : ");
char ishora = Convert.ToChar(ReadLine());

Write("Enter the second number: ");
double secondNumber = Convert.ToDouble(ReadLine());

double natija = 0;

switch (ishora)
{
    case '+':
        natija = firstNumber + secondNumber;
        break;
    case '-':
        natija = firstNumber - secondNumber;
        break;
    case '*':
        natija = firstNumber * secondNumber;
        break;
    case '/':
        natija = firstNumber / secondNumber;
        break;
}

WriteLine($"Answer: {natija}");




// 2. Raqamlar qatorining yig‘indisini hisoblash:
// Foydalanuvchidan N musbat butun sonni so‘ragan, so‘ngra 1 dan N gacha bo‘lgan barcha sonlar yig‘indisini hisoblab, natijani ekranga chiqaradigan dastur tuzing.
// Input = 10;
// Output = 55;

WriteLine("\n====== 2-Masala ======");
Write("N musbat sonini kiriting: ");
int N = Convert.ToInt32(ReadLine());

if (N < 1)
{
    WriteLine("N soni musbat bo'lishi kerak.");
    return;
}

int yigindi = 0;
for (int i = 1; i <= N; i++)
{
    yigindi += i;
}

WriteLine($"1 dan {N} gacha bo‘lgan sonlar yig‘indisi: {yigindi}");




// 3.  Paritet tekshiruvi:
// Foydalanuvchi kiritgan raqamning juft yoki toq ekanligini aniqlaydigan va shunga mos ravishda xabarni chiqaradigan dastur tuzing.
// Input = 3;
// Output = “Toq”

WriteLine("\n====== 3-Masala ======");
Write("Sonni kiriting: ");
int son = Convert.ToInt32(ReadLine());

if (son % 2 == 0)
{
    WriteLine("Juft");
}
else
{
    WriteLine("Toq");
}