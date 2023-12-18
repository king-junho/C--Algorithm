using System;
using System.Collections.Generic;

public class Solution {
    public Dictionary<char,int> GetDictionary(string[] keymap)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();

        for (int i = 0; i < 26; i++)
        {
            int minIdx = int.MaxValue;
            int index = 0;

            for (int j = 0; j < keymap.Length; j++)
            {
                if (keymap[j].Contains((char)((int)'A' + i)))
                {
                    index = keymap[j].IndexOf((char)((int)'A' + i));
                    if (index < minIdx)
                        minIdx = index;
                }

            }
            if (minIdx == int.MaxValue)
                minIdx = -1;
            map.Add((char)((int)'A' + i), minIdx);
        }//여기까지 dictionay에 다 넣음
        return map;

    }
    public int[] solution(string[] keymap, string[] targets)
    {
        int[] answer = new int[targets.Length];
        int result = 0;
        Dictionary<char, int> map;

        map = GetDictionary(keymap);

        for (int i=0; i<targets.Length; i++)
        {
            for(int j=0; j < targets[i].Length; j++)
            {
                if (map[targets[i][j]]!=-1)
                {
                    result += map[targets[i][j]]+1;
                }
                else
                {
                    result = -1;
                    break;
                }
            }
            answer[i] = result;
            result = 0;
        }

        return answer;
    }
}