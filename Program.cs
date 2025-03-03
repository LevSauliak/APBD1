Console.WriteLine("Hello, World!");
String name = Console.ReadLine();
Console.WriteLine("Your name is " + name);
Console.WriteLine("Byeee");

static int Average(int[] nums)
{
    int summa = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        summa += nums[i];
    }
    return summa/nums.Length;
}

static int Max(int[] nums)
{
    return nums.Max();
}