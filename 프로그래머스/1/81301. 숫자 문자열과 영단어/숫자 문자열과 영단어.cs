using System;

public class Solution {
    public int solution(string s) {
        string[] numbers = new string[10] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        int answer = 0;
        int index = -1;
        
        for(int i=0; i<numbers.Length; i++)
        {
            index=s.IndexOf(numbers[i]);
            if(index!=-1)
            {
                s=s.Replace(numbers[i], i.ToString());
            }
        }

        answer = int.Parse(s);
        return answer;
    }
}