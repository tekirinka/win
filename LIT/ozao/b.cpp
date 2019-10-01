#include <cstdio>

main()
{
    unsigned w, h, l, n;
    scanf("%u\n%u\n%u\n%u", &w, &h, &l, &n);
    unsigned result = w * n * 2 - w + h * (n - 1) * 2 + 2 * l;
    printf("%u", result);
}