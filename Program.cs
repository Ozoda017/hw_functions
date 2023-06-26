//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Exponentiation(int A, int B){
  int result = 1;
  for(int i=1; i <= B; i++){
    result = result * A;
  }
    // int result = Math.Pow(A, B);
    return result;
}

  Console.WriteLine("Введите число A: ");
  int A = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите число B: ");
  int B = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(A, B);
  Console.WriteLine("А в сепени B: " + exponentiation);

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

 int SumNumber(int number){

      int counter = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

  for (int i = 0; i < counter; i++){
      advance = number - number % 10;
      result = result + (number - advance);
      number = number / 10;
    }
   return result;
  }

int sumNumber = SumNumber(number);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);