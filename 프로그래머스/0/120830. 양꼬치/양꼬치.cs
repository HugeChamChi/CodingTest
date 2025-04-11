using System;

public class Solution
{
    public int solution(int n, int k)
    {
        int bonusCount = n/10;
        
        return -(bonusCount * 2000) + (n * 12000) + (k*2000);
    }
}
