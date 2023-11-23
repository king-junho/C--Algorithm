using System;

public class Solution {
    public int solution(string s)
    {
        string[] numType = new string[10] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        int answer = 0;
        int index = -1;
        
        for (int i = 0; i < numType.Length; i++)
        {
            index = s.IndexOf(numType[i]);
            if (index != -1)
            {
                answer += i;
                s = s.Replace(numType[i],i.ToString());
            }
        }

        int.TryParse(s, out answer);
        Console.Write(answer);
        return answer;
    }
}