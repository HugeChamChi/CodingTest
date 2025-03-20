using System;

public class Solution {
   // 좌표를 표현하는 구조체
    public struct Position {
        public int X; // x좌표
        public int Y; // y좌표
        
        public Position(int x, int y) {
            X = x;
            Y = y;
        }

        // 특정 위치가 유효한지 확인하는 메서드
        public bool IsValid(int size) {
            return X >= 0 && X < size && Y >= 0 && Y < size;
        }
    }

    public int solution(int[,] board) {
        int n = board.GetLength(0); // 보드 크기
        bool[,] danger = new bool[n, n]; // 위험 지역 표시용 배열

        // 8방향 이동을 위한 상대 좌표 배열
        Position[] directions = new Position[] {
            new Position(-1, -1), new Position(-1, 0), new Position(-1, 1),
            new Position(0, -1),                    new Position(0, 1),
            new Position(1, -1), new Position(1, 0), new Position(1, 1)
        };

        // 지뢰가 있는 칸과 그 주변을 위험 지역으로 표시
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (board[i, j] == 1) { // 지뢰 발견
                    danger[i, j] = true; // 지뢰 칸은 위험
                    
                    // 지뢰 주변 탐색
                    foreach (var dir in directions) {
                        Position neighbor = new Position(i + dir.X, j + dir.Y);
                        if (neighbor.IsValid(n)) { // 유효한 위치인지 확인
                            danger[neighbor.X, neighbor.Y] = true;
                        }
                    }
                }
            }
        }

        // 안전한 칸 수 계산
        int safeCount = 0;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (!danger[i, j]) { // 위험 지역이 아닌 경우
                    safeCount++;
                }
            }
        }

        return safeCount;
    }

}