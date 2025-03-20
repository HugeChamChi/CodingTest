using System;



public class Solution {
    public int[] solution(int num, int total) {
        int[] answer = new int[num];
     
        
        int start = (2 * total / num - num + 1) / 2;
        
        // 배열에 연속된 값 채우기
        for (int i = 0; i < num; i++) {
            answer[i] = start + i;
        }
        
        return answer;
    }
}