using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        List<char> charX = X.ToList();
        List<char> charY = Y.ToList();
        List<char> answerList= new List<char>();
        int idxX = 0;
        int idxY = 0;

        charX.Sort();
        charY.Sort();

        while(idxX < charX.Count && idxY<charY.Count) 
        {
            if (charX[idxX] < charY[idxY]) 
            {
                idxX++;
            }
            else if (charX[idxX]> charY[idxY])
            {
                idxY++;
            }
            else
            {
                answerList.Add(charX[idxX]);
                idxX++;
                idxY++;
            }
        }
        if (answerList.Count == 0)
            answer = "-1";
        else
        {
            answerList.Reverse();
            if (answerList[0] == '0')
            {
                answer = "0";
            }
            else
            {
                answer = new string(answerList.ToArray());
            }
        }


        return answer;
    }
}