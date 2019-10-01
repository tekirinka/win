#include <iostream>
//#include <cstring>
#include <cstdio>

//using std::cin;
//using std::string;

unsigned result (unsigned);

int main() {
  unsigned i;
  scanf("%u",&i);
  //for (i = 1; i <= 10; i++) {
    unsigned res = result(i);
    printf("%02u %02u\n", res/60%24, res%60);
  //}
}

unsigned result(unsigned n) {
  unsigned b;
  b = 9*60;
  b += 45*n;
  b += 10*n;
  b -= n%2?10:15;
  return b;
}

// 09:45 10:35 11:35