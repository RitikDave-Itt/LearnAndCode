#include <iostream>
#include <vector>
#include <unordered_map>

using namespace std;

int main()
{

    vector<int> array = {8, 2, 7, 5, 5, 3, 8, 8, 2};
    unordered_map<int, int> mp;
    int totalSum = 10;

    vector<pair<int, int>> answer;

    for (int i = 0; i < array.size(); i++)
    {
        mp[array[i]]++;
    }

    for (int i = 0; i < array.size(); i++)
    {

        if (mp[totalSum - array[i]] > 0 && mp[array[i]] > 0)
        {
            mp[array[i]]--;
            mp[totalSum - array[i]]--;

            answer.push_back(make_pair(array[i], totalSum - array[i]));
        }
    }

    for (int i = 0; i < answer.size(); i++)
    {
        cout << answer[i].first << " " << answer[i].second << endl;
    }
    return 0;
}
