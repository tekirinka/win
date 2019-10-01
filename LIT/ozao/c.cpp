#include <cstdio>

int divide(int a, int b)
{
    return (a + b - 1) / b;
}

main()
{
    unsigned h, a, b;
    scanf("%u\n%u\n%u", &h, &a, &b);
    printf("%i", divide((h - a), (a - b)) + 1);
}