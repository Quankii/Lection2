int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (result < arg2) result = arg2;
    if (result < arg3) result = arg3;
    return result;
}

int[] array = {19, 28, 37,46, 55, 64, 73,82,91};


int res = max(
    max(array[0], array[1], array[2]),
    max(array[3], array[4], array[5]),
    max(array[6], array[7], array[8]));
Console.WriteLine(res);