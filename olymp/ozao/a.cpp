#include <cstdio>

main()
{
    unsigned h, m, s;
    scanf("%u", &s);
    h = s / 3600 % 24;
    m = s / 60 % 60;
    s %= 60;
    printf("%u:%02u:%02u", h, m, s);
}