public class Solution {
    public int solution(int a, int b, int n) {
        int total = 0;
        while (n >= a) {
            int exchange = n / a;    // 이번에 교환할 수 있는 횟수
            total += exchange * b;   // 새로 받은 콜라 누적
            n = (n % a) + (exchange * b); // 남은 빈 병 + 새 콜라 빈 병
        }
        return total;
    }
}