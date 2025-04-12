using System;

public class Solution {
    public string solution(int[] food) 
    {
        string leftSide = ""; 
        string rightSide = ""; 

        for (int i = 1; i < food.Length; i++) 
        {
            int count = food[i] / 2; 
            for (int j = 0; j < count; j++) 
            {
                leftSide += i.ToString(); 
            }
        }
        for (int k = leftSide.Length - 1; k >= 0; k--) {
            rightSide += leftSide[k];
        }

        
        return leftSide + "0" + rightSide;
    }
}
