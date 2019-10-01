#include <cstdio>

main()
{
    unsigned n;
    scanf("%u",&n);
    printf("%u",(n-n%4)/4*2+n%4);
}
