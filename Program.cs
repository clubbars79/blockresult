Console.Write("Введите строки, разделяя запятой : ");
string[] A = Console.ReadLine().Split(",").ToArray();
int x = 0;
void PrintString(string[] A)
{
    Console.Write("[");
    for (x = 0; x < A.Length; x++)
    {
        Console.Write(A[x]);
        if (x < A.Length)
        {
            Console.Write(",");
        }
    }
    Console.Write("] = ");
}
PrintString(A);
void FindString(string[] A)
{
    Console.Write("[");
    for (x = 0; x < A.Length; x++)
    {
        if (A[x].Length <= 3)
        {
            Console.Write(A[x]);
            Console.Write(",");
        }
    }
    Console.Write("]");
}
FindString(A);