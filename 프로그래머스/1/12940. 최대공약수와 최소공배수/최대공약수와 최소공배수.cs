using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

public class Solution {
    public int GCD(int a, int b)
    {
        Stack<int> store = new Stack<int>();
        int min = a < b ? a : b;
        int max = a > b ? a : b;
        int result = 1;

        for (int i = 1; i <= min; i++)
        {
            if(min%i==0)
                store.Push(i);
        }
        while(store.Count > 0)
        {
            result = store.Pop();
            if (max % result == 0)
                break;
        }
        return result;
    }
    public int LCD(int a, int b)
    {
        if(GCD(a, b) == 1)
        {
            return a * b;
        }
        return GCD(a, b) * a / GCD(a, b) * b / GCD(a, b);
    }
    public int[] solution(int n, int m) {
        int[] answer = new int[2];

        answer[0] = GCD(n,m);
        answer[1] = LCD(n,m);

        Console.Write(answer[0] + " " + answer[1]);
        return answer;
    }
}