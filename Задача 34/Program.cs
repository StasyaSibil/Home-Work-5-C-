// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

var arr = GetArray();
var res = "[";
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]%2 == 0){
        count = count+1;
    }
    res = res+" "+arr[i];
}
res = res + " ]";
Console.WriteLine(res+" => "+count);

int [] GetArray(){
    int[] res = new int[4];

    for (int i = 0; i < 4; i++)
    {
        res[i]=new Random().Next(100,999);
    }

    return res;
}