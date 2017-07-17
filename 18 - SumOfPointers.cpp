#include <iostream>

using namespace std;

// İki tam sayı gösterici (integer pointer) alan ve bu göstericilerin gösterdikleri değerlerin toplamını döndüren fonksiyon programi.

int sum(int*, int*);

int main() {
	
	int* first;	
	int* second;
	
	int a = 4, b = 5;
	
	first = &a;
	second = &b;
	
	printf("%d", sum(first, second));
	
	return 0;
}

int sum(int* a, int* b)
{
	int temp;
	temp = *a + *b;
	return temp;
}
