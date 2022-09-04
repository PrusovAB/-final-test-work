string[] arrayStr = { "Hello", "2", "3", "Я", "В", "Шоке" };


void PrintArray(string[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      if (i == 0) Console.Write("[");
      if (i < array.Length - 1) Console.Write(array[i] + ",");
      else Console.Write(array[i] + "]");
   }
}

PrintArray(arrayStr);

int count = 0;

void SortArray(string[] array)
{

   for (int i = 0; i <= array.Length - 1; i++)
   {
      if (array[i].Length <= 3)
      {
         count++;
      }
   }
   string[] arrNew = new string[count];
   int cou = -1;
   for (int i = 0; i < array.Length; i++)
   {

      cou++;
      if (array[i].Length <= 3)
      {
         arrNew[i - cou] = array[i];
         cou = 0;
      }

   }
   Console.WriteLine();
   PrintArray(arrNew);
}

SortArray(arrayStr);
