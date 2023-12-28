using System;

public class Solution {
        public struct Point
    {
        public int x;
        public int y;
    }
    
    public int[] solution(string[] park, string[] routes) {
        int[] answer = new int[2];
        int[,] map = new int[park.Length, park[0].Length];
        Point startPoint = new Point();
        int heightIdx = 0;
        string[] routesArray = new string[2];

        for(int i=0; i<park.Length; i++)
        {
            int widthIdx = 0;
            foreach(char c in park[i])
            {
                if (c == 'S')
                {
                    map[heightIdx, widthIdx] = 0;
                    startPoint.x = widthIdx;
                    startPoint.y = heightIdx;
                }
                else if (c == 'O')
                {
                    map[heightIdx, widthIdx] = 1;
                }
                else
                {
                    map[heightIdx, widthIdx] = -1;
                }
                widthIdx++;
            }
            heightIdx++;
        }

        for(int i=0; i<routes.Length; i++)
        {
            routesArray = routes[i].Split(' ');
            int moveX = 0;
            int moveY = 0;
            switch(routesArray[0])
            {
                case "E":
                    if (startPoint.x + int.Parse(routesArray[1]) >= park[0].Length)
                    {
                        break;
                    }
                    moveX = startPoint.x;
                    for(int j=0; j < int.Parse(routesArray[1]); j++)
                    {
                        if (map[startPoint.y, ++moveX] == -1)
                        {
                            moveX = startPoint.x;
                            break;
                        }
                    }
                    startPoint.x = moveX;
                    break;
                case "S":
                    if (startPoint.y + int.Parse(routesArray[1]) >= park.Length)
                    {
                        break;
                    }
                    moveY = startPoint.y;
                    for (int j = 0; j < int.Parse(routesArray[1]); j++)
                    {
                        if (map[++moveY, startPoint.x] == -1)
                        {
                            moveY = startPoint.y;
                            break;
                        }
                    }
                    startPoint.y = moveY;
                    break;
                case "W":
                    if (startPoint.x - int.Parse(routesArray[1]) <0)
                    {
                        break;
                    }
                    moveX = startPoint.x;
                    for (int j = 0; j < int.Parse(routesArray[1]); j++)
                    {
                        if (map[startPoint.y, --moveX] == -1)
                        {
                            moveX = startPoint.x;
                            break;
                        }
                    }
                    startPoint.x = moveX;
                    break;
                case "N":
                    if (startPoint.y - int.Parse(routesArray[1]) < 0)
                    {
                        break;
                    }
                    moveY = startPoint.y;
                    for (int j = 0; j < int.Parse(routesArray[1]); j++)
                    {
                        if (map[--moveY, startPoint.x] == -1)
                        {
                            moveY = startPoint.y;
                            break;
                        }
                    }
                    startPoint.y = moveY;
                    break;
            }
        }
        answer[0] = startPoint.y;
        answer[1]=startPoint.x;
        Console.WriteLine(answer[0] + " " + answer[1]);
        return answer;
    }
}