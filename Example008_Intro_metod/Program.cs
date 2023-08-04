int Max ( int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result ) result = arg2;
    if(arg3 > result ) result = arg3;

    return result;
}

int a = 1;
int b = 2;
int c = 6;
int d = 88;
int e = 4;
int f = 22;
int g = 23;
int h = 31;
int i = 555;

int max1 = Max (a, b, c);
int max2 = Max (d, e, f);
int max3 = Max (g, h, i);
int max = Max (max1, max2,max3);



Console.WriteLine(max);