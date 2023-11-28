using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        //int[] alphabet = new int[26] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        //int idx = 0;
        string subString = "";

        for (int i = 0; i < s.Length; i++)
        {
            subString = s.Substring(0, i);
            if (subString.Contains(s[i]))
            {
                for (int j = subString.Length - 1; j >= 0; j--)
                {
                    if (subString[j] == s[i])
                    {
                        answer[i] = i - j;
                        break;
                    }
                }
            }
            else
            {
                answer[i] = -1;
            }
        }
        return answer;
    }
}