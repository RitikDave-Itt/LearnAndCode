using System;

class SubarrayMeanCalculator {
    static void Main(string[] args) {
        var inputParams = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int arraySize = inputParams[0];
        int queryCount = inputParams[1];

        var arrayElements = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
        long[] prefixSum = new long[arraySize + 1];
        prefixSum[0] = 0;

        for (int i = 1; i <= arraySize; i++) {
            prefixSum[i] = prefixSum[i - 1] + arrayElements[i - 1];
        }

        for (var i = 0; i < queryCount; i++) {
            var queryRange = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int leftIndex = queryRange[0];
            int rightIndex = queryRange[1];

            long subarraySum = prefixSum[rightIndex] - prefixSum[leftIndex - 1];
            int subarrayLength = rightIndex - leftIndex + 1;
            Console.WriteLine(subarraySum / subarrayLength);
        }
    }
}
