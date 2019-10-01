#include <cstdio>
//#define DEBUG

int a[31];

int main()
{
    int n, i, max = 0, sum = 0, v = 0, x;
#ifndef DEBUG
    scanf("%i", &n);
    for (i = 0; i < n; i++)
        scanf("%i", a + i);
#else
    n = 10;
    a[0] = 52;
    a[1] = 56;
    a[2] = 57;
    a[3] = 53;
    a[4] = 58;
    a[5] = 55;
    a[6] = 60;
    a[7] = 54;
    a[8] = 51;
    a[9] = 59;
#endif
    for (i = 0; i < n; i++)
        if (a[i] > a[max])
            max = i;
    for (i = 0; i < n; i++)
        v += a[i];
    max = a[max];
    x = n * v / (n - 1);
    sum = x * n - v;
    if (v >= x)
    {
        printf("-1");
    }
    else
    {
        printf("%i\n", x);
        for (i = 0; i < n; i++)
            printf("%i ", x - a[i]);
        printf("\n%i", x - sum);
    }
}
