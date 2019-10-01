#include <cstdio>
//#define DEBUG

int GET[1001];

int get (unsigned a, unsigned b)
{
    if (GET[b] == 0)
    {
        GET[b] = (get(a,b-1) == 2)?1:2;
        if(a<b)
            GET[b] = (get(a,b-a) == 2)?1:2;
    }
#ifdef DEBUG
    printf("get(%u, %u) = %i\n", a, b, GET[b]);
#endif // DEBUG
    return GET[b];
}

main()
{
    GET[1] = 2;

    unsigned a, b;
#ifndef DEBUG
    scanf("%u %u",&a,&b);
#else
    a=3;
    b=11;
#endif // DEBUG
    printf("%i",get(a,b));
}
