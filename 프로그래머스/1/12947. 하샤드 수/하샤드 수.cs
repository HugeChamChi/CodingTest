public class Solution {
    public bool solution(int x) 
    {
        // 자릿수 합 계산
        int sum = 0;
        int temp = x;

        while (temp > 0) 
        {
            sum += temp % 10; // 마지막 자릿수를 더함
            temp /= 10;       // 마지막 자릿수를 제거
        }

        // x가 자릿수 합으로 나누어떨어지면 true, 아니면 false 반환
        return x % sum == 0;
    }
}