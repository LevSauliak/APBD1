Console.WriteLine("Hello, World!");
String name = Console.ReadLine();
Console.WriteLine("Your name is " + name);
Console.WriteLine("Byeee");

static int Average(int[] nums)
{
    int sumer = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        sumer += nums[i];
    }
    return sumer/nums.Length;
}