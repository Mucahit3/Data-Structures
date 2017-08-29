#include <iostream>

using namespace std;

void Tower(int A[], int B[], int C[])
{
	int j = 8;
	for (int i = 0; i < 9; i++){
		B[j] = A[i];
		j--;
	}

	C[9] = A[9];

	j = 8;
	for (int i = 0; i < 9; i++){
		C[j] = B[i];
		j--;
	}
}

int main()
{
	int stick1[10] = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
	int stick2[10];
	int stick3[10];

	for (int i = 0; i < 10; i++){
		stick2[i] = -1;
		stick3[i] = -1;
	}

	Tower(stick1, stick2, stick3);

	for (int i = 0; i < 10; i++){
		cout << stick3[i] << endl;
	}
}