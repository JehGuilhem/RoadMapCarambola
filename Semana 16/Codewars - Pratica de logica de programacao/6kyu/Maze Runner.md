# Maze Runner

link: https://www.codewars.com/kata/58663693b359c4a6560001d6

You will be given a 2D array of the maze and an array of directions. Your task is to follow the directions given. If you reach the end point before all your moves have gone, you should return Finish. If you hit any walls or go outside the maze border, you should return Dead. If you find yourself still in the maze after using all the moves, you should return Lost.
'''
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    class Kata
    {
        public string mazeRunner(int[,] maze, string[] directions)
        {
          int startX = 0;
          int startY = 0;
          
          double size = Math.Sqrt(maze.Length);
            
          for (int i = 0; i < size; i++)
          {
            for (int j = 0; j < size; j++)
            {
              if (maze[j, i] == 2) 
              { 
                startX = i; 
                startY = j;
              }
            }
          }
            for (int i = 0; i < directions.Length; i++)
            {
              switch (directions[i])
              {
                case "N": startY -= 1; break;
                case "E": startX += 1; break;
                case "S": startY += 1; break;
                case "W": startX -= 1; break;
              }             
              if (startY < 0 || startY > size - 1 || startX < 0 || 
                  startX > size - 1 || maze[startY, startX] == 1)  return "Dead";               
              
              if (maze[startY,startX] == 3) { return "Finish"; }
            }
            return "Lost";      
        }
    }
}'''
