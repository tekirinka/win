#include <cstdio>

main()
{
    unsigned a, b;
    scanf("%u\n%u", &a, &b);
    unsigned result = (a - (b % a)) % a;
    printf("%u", result);
}