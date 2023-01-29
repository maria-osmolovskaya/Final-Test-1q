/* Программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
*/

string[] array1 = {"Hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "-2", "computer science"};
string[] array3 = {"Russia", "Denmark", "Kazan"};


//метод решения задачи - формирования нового массива
string [] GetNewArray(string [] array)
{
    string [] newarray = new string [array.Length];
    int count = 0;
    int Length = array.Length;
    int maxDigits = 3;
      
    for (int i = 0; i < Length; i++)
    {
            if (array[i].Length <= maxDigits)
            {
              newarray[count] = array[i];
              count++;
            }
        }
        
        return newarray;
    }

// метод печати маccива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
   
string [] newarray1 = GetNewArray(array1);
PrintArray(newarray1);
Console.WriteLine();
string [] newarray2 = GetNewArray(array2);
PrintArray(newarray2);
Console.WriteLine();
string [] newarray3 = GetNewArray(array3);
PrintArray(newarray3);
