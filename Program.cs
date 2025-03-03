Console.WriteLine("Hello, World!");
String name = Console.ReadLine();
Console.WriteLine("Your name is " + name);
Console.WriteLine("Byeee");

static int Average(int[] nums)
{
    int sum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        sum += nums[i];
    }
    return sum/nums.Length;
}