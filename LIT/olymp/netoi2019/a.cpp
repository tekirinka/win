#include <cstdio>

unsigned long max (unsigned long a, unsigned long b)
{
    return(a>b?a:b);
}

main()
{
    unsigned v1,v2,v3,t1,t2,t3;
    scanf("%u %u %u %u %u %u", &v1, &t1, &v2, &t2, &v3, &t3);
    //printf("%u %u %u %u %u %u", v1, v2, v3, t1, t2, t3);
    unsigned long l1 = v1 * t1,
                  l2 = v2 * t2,
                  l3 = v3 * t3;
    //printf("%u\n%u\n%u\n",l1,l2,l3);
    unsigned long m = max(max(l1,l2),l3);
    if(m==l1)
        printf("1 ");
    if(m==l2)
        printf("2 ");
    if(m==l3)
        printf("3 ");
    printf("\n");
}
