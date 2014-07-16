using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class frame
    {
        public int r1;
        public int r2;
        public int score;

        public frame(int p1,int p2)
        {
        // TODO: Complete member initialization
            this.r1 = p1;
            this.r2 = p2;
        }
        public frame()
        {
            this.r1 = 0;
            this.r2 = 0;
        }
        public frame(int pins)
        {
        // TODO: Complete member initialization
            this.r1 = pins;
        }
    }
    public class Game
    {
        public frame[] FrameList = new frame[15];
        public int flag=0,totalScore = 0, j=0,chance = 0,prevPins=0,i=0,prevChance=0;
        int b1=0, b2=0;
        public int[] store=new int[2];
        public int[] chances=new int[12];
        public void Roll(int pins)
        {
            if (i == 9)
            {
                if (flag == 0)
                {
                    FrameList[i] = new frame();
                    FrameList[i].r1 = pins;
                    flag = 1;
                }
                else
                {
                    if (b1 == 0)
                        b1 = pins;
                    else
                        b2 = pins;
                }
            }
            else
            {
                if (pins == 10)
                {
                    FrameList[i] = new frame();
                    FrameList[i].r1 = pins;
                    FrameList[i].r2 = 0;
                    i++;
                }
                else
                {
                    if (flag == 0)
                        FrameList[i] = new frame();
                    if ((pins > 0 && pins < 10) && flag == 0)
                    {
                        FrameList[i].r1 = pins;
                        flag = 1;
                    }
                    else
                    {
                        FrameList[i].r2 = pins;
                        flag = 0;
                        i++;
                    }
                }
            }
        }
        public int GetScore()
        {
            for (int j = 0; j < 10; j++)
            {
                if (j == 9)
                {
                    totalScore = totalScore + FrameList[j].r1;
                    if (FrameList[j].r1 == 10)
                    {
                        totalScore += b1;
                        totalScore += b2;
                        return totalScore;
                    }
                    else if((FrameList[j].r1+b1)==10)
                    {
                        //totalScore += FrameList[j].r1;
                        totalScore += b1;
                        totalScore += b2;
                    }
                    else
                    {
                        totalScore += (b1 + b2);
                            //totalScore += FrameList[j].r2;
                    }
                    return totalScore;
                }
                if (FrameList[j].r1 == 10)
                {
                    totalScore = totalScore + FrameList[j].r1;
                       if (FrameList[j+1].r1 == 10)
                        {
                            totalScore += FrameList[j+1].r1;
                            totalScore += b1;
                        }
                        else
                        {
                            totalScore += FrameList[j+1].r1;
                            totalScore += FrameList[j+1].r2;
                        }
                }
                else if ((FrameList[j].r1 + FrameList[j].r2) == 10)
                {
                    totalScore += (FrameList[j].r1 + FrameList[j].r2);
                    totalScore+=FrameList[j+1].r1;
                }
                else
                {
                    totalScore += FrameList[j].r1;
                    totalScore += FrameList[j].r2;
                }
            }
            return totalScore;
        }
    }
}


           