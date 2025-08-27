
int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (result < arg2) result = arg2;
    if (result < arg3) result = arg3;
    return result;
}

int a1 = 20;
int b1 = 211;
int c1 = 22;
int a2 = 23;
int b2 = 24;
int c2 = 25;
int a3 = 26;
int b3 = 27;
int c3 = 28;

int res = max(
    max(a1, b1, c1),
    max(a2, b2, c2),
    max(a3, b3, c3));
Console.WriteLine(res);