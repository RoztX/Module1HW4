Console.WriteLine("Укажите размер массива :");
var arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];
var arrayOddSize = 0;
var arrayEvenSize = 0;
for (int i = 0; i < arraySize; i++)
{
    array[i] = new Random().Next(1, 26);
    if (array[i] % 2 == 0)
    {
        arrayEvenSize++;
    }
    else
    {
        arrayOddSize++;
    }
}

InputArrayInt(array);
char[] arrayEvenNumbers = new char[arrayEvenSize];
char[] arrayOddNumbers = new char[arrayOddSize];
char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
int numberOfEvenLetters = 0;
int numberOfOddLetters = 0;
for (int i = 0; i < arraySize; i++)
{
    if (array[i] % 2 == 0)
    {
        arrayEvenNumbers[numberOfEvenLetters++] = alphabet[array[i]];
    }
    else
    {
        arrayOddNumbers[numberOfOddLetters++] = alphabet[array[i]];
    }
}

int evenCounter = SearchLetter(arrayEvenNumbers);
int oddCounter = SearchLetter(arrayOddNumbers);
Console.WriteLine("Массив четных чисел :");
InputArrayChar(arrayEvenNumbers);
Console.WriteLine(string.Empty);
Console.WriteLine("Массив нечетных чисел :");
InputArrayChar(arrayOddNumbers);
if (evenCounter > oddCounter)
{
    Console.WriteLine("В массиве четных чисел больше символов в верхнем регистре");
}
else if (evenCounter < oddCounter)
{
    Console.WriteLine("В массиве нечетных чисел больше символов в верхнем регистре");
}
else
{
    Console.WriteLine("В массивах одинаковое число символов в верхнем регистре");
}

Console.WriteLine($"Число символов в первом массиве {arrayEvenSize} из них {evenCounter} положительных");
Console.WriteLine($"Число символов во втором массиве {arrayOddSize} из них {oddCounter} положительных");

int SearchLetter(char[] array)
{
    int numbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        switch (array[i])
        {
            case 'a':
                array[i] = 'A';
                numbers++;
                break;
            case 'e':
                array[i] = 'E';
                numbers++;
                break;
            case 'i':
                array[i] = 'I';
                numbers++;
                break;
            case 'd':
                array[i] = 'D';
                numbers++;
                break;
            case 'h':
                array[i] = 'H';
                numbers++;
                break;
            case 'j':
                array[i] = 'J';
                numbers++;
                break;
        }
    }

    return numbers;
}

void InputArrayInt(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine(" ");
}

void InputArrayChar(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine(" ");
}
