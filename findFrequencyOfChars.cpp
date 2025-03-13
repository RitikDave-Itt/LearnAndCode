#include <iostream>
#include <vector>
#include <unordered_map>
#include <string>

using namespace std;

int main()
{
    unordered_map<char, int> mp;

    string str = "aaaaa6678aa";

    for (int i = 0; i < str.size(); i++)
    {
        mp[str[i]]++;
    }

    for (auto c : mp)
    {
        if (c.second > 1)
        {
            cout << c.first << ":" << c.second << endl;
        }
    }
}