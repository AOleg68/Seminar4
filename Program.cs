//Написать программу, которая преобразует массив целых чисел в массив чисел, 
//в котором находятся только четные числа

int[] array  = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14};
int index = 0;
int size = 14;

while (index < size)
{
        if (array [index] % 2 == 0)
        {
            Console.WriteLine (array[index]);
        }
        
index++;  
         
}


