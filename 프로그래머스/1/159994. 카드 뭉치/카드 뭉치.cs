using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) 
    {
        
        int index1 = 0; // cards1 배열의 현재 위치
        int index2 = 0; // cards2 배열의 현재 위치

        foreach (string word in goal) 
        {
            // cards1에서 단어를 찾을 수 있는 경우
            if (index1 < cards1.Length && cards1[index1] == word)
            {
                index1++; // 다음 단어로 이동
            }
            // cards2에서 단어를 찾을 수 있는 경우
            else if (index2 < cards2.Length && cards2[index2] == word) 
            {
                index2++; // 다음 단어로 이동
            }
            
            else 
            {
                return "No";
            }
        }

        return "Yes"; 
    }
}
