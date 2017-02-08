﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Snake
{
    class wall
    {
        public char sign;
        public ConsoleColor color;
        List<Point> body;

        public wall(){
            sign='*';
            color = ConsoleColor.Green;
            body = new List<Point>();
            StreamReader sr = new StreamReader("input.txt");
            int n = int.Parse(sr.ReadLine());
            for (int i= 0; i<n; i++) 
            {
                string line = sr.ReadLine();
                for(int j=0; j<line.Length; j++)
                {
                    if (line[j]=='*')
                        body.Add(new Point(j,i));
                }
            }
            sr.Close();
        }

             public void Draw ()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.WriteLine(sign);

            }
             }

        }

    }

