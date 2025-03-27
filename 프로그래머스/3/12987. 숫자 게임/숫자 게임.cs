using System;

using System;

public class Solution {
    public int solution(int[] A, int[] B) {
        // 배열 정렬 (오름차순)
        Array.Sort(A);
        Array.Sort(B);

        int aPointer = 0; // A팀 포인터
        int bPointer = 0; // B팀 포인터
        int score = 0;    // B팀이 얻은 승점

        // 두 배열을 순회하며 비교
        while (aPointer < A.Length && bPointer < B.Length) {
            if (A[aPointer] < B[bPointer]) {
                // A팀의 숫자가 B팀의 숫자보다 작다면 승점 획득
                score++;
                aPointer++; // A팀 다음 선수로 이동
                bPointer++; // B팀 다음 선수로 이동
            } else {
                // A팀이 이길 수 없으면 B팀 포인터만 이동
                bPointer++;
            }
        }

        return score;
    }
}
