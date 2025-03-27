using System;

public class Solution {
    public int solution(int[] dot) {
        // x 좌표와 y 좌표를 가져옴
        int x = dot[0];
        int y = dot[1];

        // 사분면 판단
        if (x > 0 && y > 0) {
            return 1; // 제1사분면
        } else if (x < 0 && y > 0) {
            return 2; // 제2사분면
        } else if (x < 0 && y < 0) {
            return 3; // 제3사분면
        } else if (x > 0 && y < 0) {
            return 4; // 제4사분면
        }

       return -1;
    }
}
