using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[4];
        int minx = int.MaxValue;
        int miny = int.MaxValue;
        int maxx = int.MinValue;
        int maxy = int.MinValue;

        for(int i=0; i<wallpaper.Length; i++)
        {
            char[] charArray = wallpaper[i].ToCharArray();
            Array.Reverse(charArray);
            string reverseString = new string(charArray);
 
            if (wallpaper[i].Contains("#"))
            {
                if(minx > wallpaper[i].IndexOf("#"))
                {
                    minx = wallpaper[i].IndexOf("#");
                }
                maxy = i+1;
                if (miny == int.MaxValue)
                    miny = i;
            }
            if(reverseString.Contains("#"))
            {
                if (maxx < reverseString.Length - reverseString.IndexOf("#"))
                {
                    maxx=reverseString.Length - reverseString.IndexOf("#");
                }
            }
        }

        answer[0] = miny;
        answer[1] = minx;
        answer[2] = maxy;
        answer[3] = maxx;

        return answer;
    }
}