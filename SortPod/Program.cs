//сортировка подсчетом работает только с цифрами(0-9)(по умолчанию)
using System.Diagnostics.Metrics;
using System.Threading.Tasks.Dataflow;

int[] arr = { 0, 2, 3, 2, 1, 5, 9, 1, 1, 7, 3, 8, 3, 7, 5, 2, 6, 8, 1 };
int[] arr2 = { 0, 2, 4, 10, 20, 5, 6, 1, 2 };
int[] arr3 = { -10, -5, -9, 10, 0, 2, 5, 1, 3,1,0,1 };

CountingSort(arr);
Console.WriteLine(string.Join(";", arr));

arr2 = CountingSortExtended(arr2);
Console.WriteLine(string.Join(";", arr2));

arr3 = CountingSortExtended(arr3);
Console.WriteLine(string.Join(";", arr3));

Console.ReadLine();


void CountingSort(int[] inputArray)
{
    int[] counter = new int[10];//массив повторений
    int ourNumber;


    for (int i = 0; i < inputArray.Length; i++)
    {
        //counter[inputArray[i]]
        ourNumber = inputArray[i];
        counter[ourNumber]++;
    }
    int count = 0;
    for (int i = 0; i < counter.Length; i++)
    {
        for (int j = 0; j < counter[i]; j++)
        {
            inputArray[count] = i;
            count++;
        }
    }
}

int[] CountingSortExtended(int[] inputArray)
{
    int max = inputArray.Max();//ищем макс эл, чтобы задать массив равному этому числу
    int min = inputArray.Min();

    int offset = -min;//смещение, при минусовом элементе
    int[] sortedArray = new int[inputArray.Length];
    int[] counters = new int[max + offset+ 1];//массив для подсчётов

    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i]+offset]++;
    }
    int count = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            sortedArray[count] = i- offset;
            count++;
        }
    }

    return sortedArray;
}

