//  Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

var arr = GetArray();
double min = arr[0];
double max = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (min > arr[i]){
        min = arr[i];
    }

    if (max < arr[i]){
        max = arr[i];
    }
}
var res = max-min;
Console.WriteLine(max + " - " + min + " = "+ res);

double [] GetArray(){
    double[] res = new double[4];

    for (int i = 0; i < 4; i++)
    {
        res[i]=new Random().NextDouble();
    }

    return res;
}