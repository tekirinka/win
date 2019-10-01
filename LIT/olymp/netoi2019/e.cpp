#include <cstdio>
//#define DEBUG

int a[44];

main()
{
    int pN, cN, N;
#ifndef DEBUG
    scanf("%i %i %i",&pN,&cN,&N);
    for (int i = 0; i < pN*cN; i++)
        scanf("%i", a+i);
#else
    pN=4;
    cN=3;
    N=30+37+29+36;
    a[0]=30;
    a[1]=37;
    a[2]=29;
    a[3]=36;
    a[4]=38;
    a[5]=32;
    a[6]=31;
    a[7]=36;
    a[8]=35;
    a[9]=38;
    a[10]=34;
    a[11]=30;
#endif // DEBUG
    int i;
    for(i=0; N>a[i]; i++)
    {
        N-=a[i];
    }
    int c = i%cN+1;
    int p = i/cN+1;
    printf("%i %i %i", p, c, N);
}
