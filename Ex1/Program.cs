

int[] nums = {1, 2, 3 ,4 , 6, 7};
int find = 5;
byte count = 0;
int n = nums.Length;

while (count < n)
{
    if (nums[count] == find)
    {
        Console.WriteLine(find + " is in nums");
        break;
    }

    count++;

}