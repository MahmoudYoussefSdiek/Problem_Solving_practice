#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

void findZigZagSequence(int a[], int n) {
    // Sort the array
    for (int i = 0; i < n - 1; i++) {
        for (int j = 0; j < n - i - 1; j++) {
            if (a[j] > a[j + 1]) {
                int temp = a[j];
                a[j] = a[j + 1];
                a[j + 1] = temp;
            }
        }
    }

    // Perform the zig zag transformation
    int mid = n / 2;
    int temp = a[mid];
    a[mid] = a[n - 1];
    a[n - 1] = temp;

    int st = mid + 1;
    int ed = n - 2;
    while (st <= ed) {
        int temp = a[st];
        a[st] = a[ed];
        a[ed] = temp;
        st++;
        ed--;
    }
}

int main() {
    int testCases;
    scanf("%d", &testCases);

    for (int cs = 0; cs < testCases; cs++) {
        int n;
        scanf("%d", &n);

        int a[n];
        for (int i = 0; i < n; i++) {
            scanf("%d", &a[i]);
        }

        findZigZagSequence(a, n);

        for (int i = 0; i < n; i++) {
            if (i == n - 1) {
                printf("%d\n", a[i]);
            } else {
                printf("%d ", a[i]);
            }
        }
    }

    return 0;
}