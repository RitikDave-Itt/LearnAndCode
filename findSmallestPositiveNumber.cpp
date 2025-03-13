#include <iostream>
#include <vector>
#include <unordered_map>

using namespace std;

int main()
{
    int size;
    cin >> size;

    int array[size];

    for (int i = 0; i < size; i++)
    {
        cin >> array[i];
    }

    sort(array, array + size);

    int smallestNo = 1;

    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0 && array[i] != smallestNo)
        {
            break;
        }
    }
    cout << "The smallest missing positive number is:" << smallestNo;
    return 0;
}