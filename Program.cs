using System.IO.Compression;

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2 > result) result = arg2;
//     if(arg3 > result) result = arg3;
//     return result;
// }

// int a1 = 1;
// int a2 = 2;
// int a3 = 3454;
// int b1 = 4;
// int b2 = 6;
// int b3 = 5;
// int c1 = 18;
// int c2 = 746;
// int c3 = 56;

// int[] array = {1,2,33,4,52,6,7,18,9};
// array[0] = 12;

// int max1 = Max(a1,a2,a3);
// int max2 = Max(b1,b2,b3);
// int max3 = Max(c1,c2,c3);

// int max = Max(Max(array[0],array[1],array[2]),Max(array[3],array[4],array[5]),Max(array[6],array[7],array[8]));
// Console.WriteLine(max);

// Console.Clear();
// int[] array = {23,434,245,434,34,5};
// int find = 434;
// int index = 0;
// while(index < array.Length)
// {
//     if(array[index]==find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++;    
// }

Console.Clear();
void FillArray(int[] collection)
{
    int i = 0;
    while(i < collection.Length)
    {
        collection[i] = new Random().Next(1,10);
        i++;
    }
}
void PrintArray(int[] col)
    {
        int i1 = 0;
        while(i1<col.Length)
        {
            Console.WriteLine(col[i1]);
            i1++;
        }
    }

int Indexof(int[] collection, int find)
{
    int ind = 0;
    int position = -1;
    while(ind < collection.Length)
    {
        if(collection[ind]==find)
        {
            position = ind;
            break;
        }
        ind++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array[2]= 4;
array[5]= 4;
array[7]= 4;
PrintArray(array);
Console.WriteLine();
int pos = Indexof(array, 434);
Console.WriteLine(pos);