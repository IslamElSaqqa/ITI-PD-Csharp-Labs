using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class ArrayUtils{
    public static void Reverse(int[] arr)
    {
        int start = 0;
        int end = arr.Length - 1;
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }
    public static int FindMax(int[] arr)
    {

        int max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }
    public static int FindMin(int[] arr)
    {

        int min = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }
    public static bool IsSorted (int[] arr)
    {
        bool isSorted = true;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                isSorted = false;
                break;
            }
        }

        return isSorted;
    }
    public static int CountOccurrences(int[] arr, int target)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                count++;
            }
        }
        return count; 
    }
    public static int[] MergeSortedArrays(int[] arr1, int[] arr2)
    {
        int[] merged = new int[arr1.Length + arr2.Length];
        int i = 0, j = 0, k = 0;
        while (i < arr1.Length && j < arr2.Length)
        {
            if (arr1[i] < arr2[j])
            {
                merged[k++] = arr1[i++];
            }
            else
            {
                merged[k++] = arr2[j++];
            }
        }
        while (i < arr1.Length)
        {
            merged[k++] = arr1[i++];
        }
        while (j < arr2.Length)
        {
            merged[k++] = arr2[j++];
        }
        return merged;
    }
}
class BankAccount
{
    private string accountNumber;
    private string ownerName;
    private float balance;

    public BankAccount() { }
    public BankAccount(string accountNumber, string ownerName, float balance)
    {
        this.accountNumber = accountNumber;
        this.ownerName = ownerName;
        this.balance = balance;
    }

    public string AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }

    public string OwnerName
    {
        get { return ownerName; }
        set { ownerName = value; }
    }

    public float Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public void Deposit(float amount)
    {
        balance += amount;
    }

    public void Withdraw(float amount)
    {
        balance -= amount;
    }

    public void Transfer(BankAccount targetAccount, float amount)
    {
        if (amount <= balance)
        {
            this.Withdraw(amount);
            targetAccount.Deposit(amount);
        }
    }


    public void DisplayInfo()
    {
        Console.Write("Account Info:\nAccount-Number: " + accountNumber + "\nBalance: " + balance + "\nOwner-Name: " + ownerName);
    }

}


class Program
{
    static void ArrayRotation(int[] a, int k)
    {
        int n = a.Length;
        k = k % n;
        for (int i = 0; i < k; i++)
        {  // if K = 2 => loop from 0 to 2 {1,2,3}
            // Get the last element 
            int last = a[n - 1]; //5
            for (int j = n - 1; j > 0; j--)
            {
                a[j] = a[j - 1]; // first iteration = {1,2,3,4,4}, second iteration = {1,2,3,3,4}, Third Iteration = {1,2,2,3,3}, fourth iteration = {1,1,2,2,3}
            }
            a[0] = last;
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine("");
    }
    static int[,] SprialMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        int value = 1;
        int left = 0, right = n - 1, down = n - 1, up = 0;
        //Edges (Left -> Right) , (Right -> Down), (Down -> up by Left --)
        while (left <= right && up <= down)
        {

            // Move and Fill to the Right
            for (int i = left; i <= right; i++)
            {
                matrix[up, i] = value++;
            }
            up++; // becomes 1

            //Move to down
            for (int i = up; i <= down; i++)
            {
                matrix[i, right] = value++;
            }
            right--;

            // Move to left
            for (int i = right; i >= left; i--)
            {
                matrix[down, i] = value++;
            }
            down--;

            // Move to up
            for (int i = down; i >= up; i--)
            {
                matrix[i, left] = value++;
            }
            left++;
        }

        return matrix;
    }

    static void printSpiralMatrix(int[,] m)
    {
        int rows = m.GetLength(0);
        int cols = m.GetLength(1);
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                Console.Write(m[i, j] + " ");
        Console.WriteLine("");
    }

    static int[][] GeneratePascalsTriangle(int n)
    {
        int[][] triangle = new int[n][];

        for (int i = 0; i < n; i++)
        {
            triangle[i] = new int[i + 1];
            triangle[i][0] = 1;
            triangle[i][i] = 1;

            // Fill the inner elements
            for (int j = 1; j < i; j++)
            {
                triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
            }
        }

        return triangle;
    }

    static void PrintJaggedArray(int[][] m)
    {

        for (int i = 0; i < m.Length; i++)
        {
            Console.Write(new string(' ', (m.Length - i - 1) * 2));
            for (int j = 0; j < m[i].Length; j++)
            {
                Console.Write(m[i][j] + "   ");
            }
            Console.WriteLine();
        }
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine("");
    }
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            bool swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    Swap(ref arr[j], ref arr[j + 1]);
                    swapped = true;
                }
            }
            if (!swapped)
            {
                Console.WriteLine("Array is already sorted!");
                break;
            }
        }
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                Swap(ref arr[i], ref arr[minIndex]);
            }
        }
    }

    static void WordFrequencyCounter(string s)
    {
        //? To lOwer
        s = s.ToLower();
        string[] words = s.Split(' ');

        //? Creating a dictionary
        Dictionary<string, int> freq = new Dictionary<string, int>();
        //? Initially empty { "The" : 2, "Best": 1, "Worse": 1}
        //? freq {
        //?     The => 1  word = "the" 
        //?     Best => 1
        //?     The  => 1
        //?     Worse => 1
        //? }

        foreach (string word in words)
        {
            if (freq.ContainsKey(word))
                freq[word]++;
            else
                freq[word] = 1;
        }

        //? sorting freq in desc
        var sorted = freq.OrderByDescending(x => x.Value);
        foreach (var item in sorted)
        {
            Console.WriteLine(string.Concat(item.Key, " - ", item.Value));
        }

    }
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int k = 2;
        ArrayRotation(arr, k);

        Console.WriteLine("--------------------------");

        Console.Write("Enter the Size of the Matrix to be filled: ");
        int size = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Filling the matrix inward");
        int[,] Matrix = SprialMatrix(size);
        printSpiralMatrix(Matrix);

        Console.WriteLine("--------------------------");
        int JaggedArraySize = 4;
        int[][] jagged = GeneratePascalsTriangle(JaggedArraySize);
        PrintJaggedArray(jagged);

        Console.WriteLine("--------------------------");
        int[] UnsortedArray = { 50, 10, 4, 6, 29 };
        Console.WriteLine("Array before using Bubble Sort: ");
        PrintArray(UnsortedArray);
        Console.WriteLine("---------------------------");
        Console.WriteLine("Array After using Bubble Sort: ");
        BubbleSort(UnsortedArray);
        PrintArray(UnsortedArray);

        Console.WriteLine("--------------------------");
        int[] arr2 = { 99, 20, 101, 304, 29 };
        Console.WriteLine("Array before using selection Sort: ");
        PrintArray(arr2);
        Console.WriteLine("---------------------------");
        Console.WriteLine("Array After using selection Sort: ");
        SelectionSort(arr2);
        PrintArray(arr2);
        Console.WriteLine("----------------------------");

        BankAccount acc1 = new BankAccount("A1", "Ahmed", 5000);
        BankAccount acc2 = new BankAccount("A2", "Sara", 3000);

        Console.WriteLine("Before Transferring.....");
        Console.WriteLine();
        acc1.DisplayInfo();
        Console.WriteLine("");
        acc2.DisplayInfo();

        Console.WriteLine("\n-----------------------------\n");

        // Transfer 2000 from Ahmed to Sara
        acc1.Transfer(acc2, 2000);

        Console.WriteLine("After Transferring ......");
        Console.WriteLine("");
        acc1.DisplayInfo();
        Console.WriteLine("");
        acc2.DisplayInfo();

        Console.WriteLine("--------------------------------------------------");
        int[] UnreversedArray = { 20, 10, 2, 70, 3 };
        Console.WriteLine("Original Array: " + string.Join(", ", UnreversedArray));

        ArrayUtils.Reverse(UnreversedArray);
        Console.WriteLine("Reversed Array: " + string.Join(", ", UnreversedArray));

        int max = ArrayUtils.FindMax(UnreversedArray);
        Console.WriteLine("Max Value: " + max);

        int min = ArrayUtils.FindMin(UnreversedArray);
        Console.WriteLine("Min Value: " + min);

        bool sorted = ArrayUtils.IsSorted(UnreversedArray);
        Console.WriteLine("Is Sorted: " + sorted);

        int count = ArrayUtils.CountOccurrences(UnreversedArray, 10);
        Console.WriteLine("Occurrences of 10: " + count);

        int[] NumsArray = { 1, 4, 5, 6 };
        int[] merged = ArrayUtils.MergeSortedArrays(UnreversedArray, NumsArray);
        Console.WriteLine("Merged Array: " + string.Join(", ", merged));

        Console.WriteLine("-------------------------------------------");
        Console.Write("Enter a string to Count words Frequency: ");
        string statement = Console.ReadLine()!;
        WordFrequencyCounter(statement);

    }
}
