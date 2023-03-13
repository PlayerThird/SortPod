//сортировка подсчетом работает только с цифрами(0-9)(по умолчанию)
using System.Threading.Tasks.Dataflow;

int[] arr = { 0, 2, 3, 2, 1, 5, 9, 1, 1,7,3,8,3,7,5,2,6,8,1 };

CountingSort(arr);
Console.WriteLine(string.Join(";", arr));
Console.ReadLine();
void CountingSort(int[] inputArray)
{
    int[] counter= new int[10];//массив повторений
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