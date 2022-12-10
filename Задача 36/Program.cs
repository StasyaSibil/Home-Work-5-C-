// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

var arr = GetArray();
int res = 0;
var str = "[";
for (int i = 0; i < arr.Length; i++)
{
    if (i != 0 && i % 2 != 0){
        res = res + arr[i];
    }
    str = str+" "+arr[i];
}
str = str + " ]";
Console.WriteLine(str+" => "+res);

int [] GetArray(){
    int[] res = new int[4];

    for (int i = 0; i < 4; i++)
    {
        res[i]=new Random().Next(-100,100);
    }

    return res;
}