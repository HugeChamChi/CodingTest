using System;

public class Solution {
    public int solution(int n) {
        int pizza = 0;
        int totalslices=0;
        
        while (totalslices <n)
        {
            pizza++;
            totalslices +=7;
        }
        
        return pizza;
       
    }
}