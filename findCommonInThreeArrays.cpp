#include <iostream>
#include <vector>
#include <unordered_map>

using namespace std;

int main()
{
    int arr1[] = {1, 2, 3, 4, 5, 6};
    int arr2[] = {1, 3, 4, 6, 7, 6};
    int arr3[] = {3, 6, 4, 5, 6, 7};
    vector<int> answer;

    unordered_map<int, bool> arr1Map;
    unordered_map<int, bool> arr2Map;
    unordered_map<int, bool> arr3Map;

    for (int i = 0; i < 6; i++)
    {
        arr1Map[arr1[i]] = true;
        arr2Map[arr2[i]] = true;
        arr3Map[arr3[i]] = true;
    }
    for (int i = 0; i < 6; i++)
    {
        if (arr1Map[arr1[i]] && arr2Map[arr1[i]] && arr3Map[arr1[i]])
        {
            answer.push_back(arr1[i]);
        }
    }

    for (int i = 0; i < answer.size(); i++)
    {
        cout << answer[i] << " ";
    }
    return 0;
}