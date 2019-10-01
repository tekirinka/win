#include <cstdio>

main()
{
    unsigned n;
    scanf("%u",&n);
    printf("%u",(n-n%8)/8*2+n%8);
}
