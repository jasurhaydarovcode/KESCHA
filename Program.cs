// ﻿ Basics.Tanlash bo’limi uchun 1-amaliy vazifa
using System;
using static System.Console;

// 1. String ustida amallar
// String tipida (string str) qiymat berilgan. Consoleda int tipidagi qiymat kiriting. Agar bu son str ning uzunligidan katta bo’lsa, str ni katta harflarga o’giring, aks holda kichik harflarga o’giring.
// Input: x=13, str=”teLefOn”
// Output: “TELEFON”
// ---------------
// Input: x=4, str=”komPyuter”
// Output: “kompyuter”


WriteLine("====== 1-Masala ======");

string str = "komPyuter";
WriteLine("Sonni kiriting: ");
int son = Convert.ToInt32(ReadLine());

// if, else operation
// if(son > str.Length){
//     WriteLine(str.ToUpper());
// }
// else{
//     WriteLine(str.ToLower());
// }

// Ternariy Operation
string result =
    son > str.Length
        ? str.ToUpper()
        : str.ToLower();

WriteLine(result);









// 2. Quyida ternary operator bilan ifodalandan qiymatni if-else yordamida ifodalang.

WriteLine("\n====== 2-Masala ======");

WriteLine("Ternary operatorida yozilgan kod if else yordamida ifodalandi!");
int x = 15;
int y = 10;

// string result = (x > y)
//     ? "x is grater than y"
//     : (x < y)
//         ? "x is less than y"
//         : (x == y)
//             ? "x is equal to y"
//             : "x and y are not comparable";

// WriteLine(result);

if (x > y)
{
    WriteLine("x is greater than y");
}
else if (x < y)
{
    WriteLine("x is less than y");
}
else if (x == y)
{
    WriteLine("x is equal to y");
}
else
{
    WriteLine("x and y are not comparable");
}









// 3. Consoleda o’zbek tilida kiritilgan hafta kunini ingliz tiliga o’girib,
//  natijani ekranga chiqaradigan dastur tuzing. Switch expression dan foydalaning!


WriteLine("\n====== 3-Masala ======");

WriteLine("Insatlgan hafta kunini kiriting (o'zbek tilida): ");
string operation = ReadLine();
string natija = operation switch
{
    "dushanba" => "Monday",
    "seshanba" => "Tuesday",
    "chorshanba" => "Wednesday",
    "payshanba" => "Thursday",
    "juma" => "Friday",
    "shanba" => "Saturday",
    "yakshanba" => "Sunday",
    _ => "kichik hafrlar bilan kiriting ||  No'tog'ri hafta kuni!"
};

WriteLine(natija);
