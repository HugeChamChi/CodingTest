using System;

public class Solution {
    public int solution(int slice, int n) 

    {
       int pizza =0;
       int totalSlices =0;
        
        
        while ( totalSlices<n)
        {
            pizza++;
            totalSlices += slice;
        }
        return pizza;
     
    }
}