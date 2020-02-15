using System;
using System.Collections.Generic;

namespace dojodachi.Models
{
    public class Kirby
    {
        public int Happiness{get;set;}
        public int Fullness{get;set;}
        public int Meals{get;set;}
        public int Energy{get;set;}
        public bool isAlive{get;set;}
        public string Emotion{get;set;}
        public List<string> Log{get;set;}
    
        public Kirby()
        {
            Happiness = 20;
            Fullness = 20;
            Energy = 50;
            Meals = 3;
            isAlive = true;
            Emotion = "~/imgs/kirby.png";
            Log = new List<string>();
        }
        public void Feed() {
            if (Meals > 0) {
                Meals--;
                Random rand = new Random();
                int chance = rand.Next(0,4);
                if(chance==0)
                {
                    Happiness-=3;
                    Log.Insert(0,"Kirby did not like the meal!");
                    if(Happiness <= 0)
                    {
                        isAlive = false;
                        Log.Insert(0,"Kirby died from the aweful meal!");
                    }
                }
                else
                {
                   Fullness+=rand.Next(5,11);
                   Log.Insert(0,"Kirby liked the meal!");
                   if(Energy >= 100 && Happiness >= 100 && Fullness >= 100)
                    {
                        isAlive = false;
                        Log.Insert(0,"Kirby is.... full? Good job!");
                    }
                }
            }
            
             
        }

        public void Play()
        {
            Energy -= 5;
            Random rand = new Random();
            int chance = rand.Next(0,4);
            if(chance==0)
            {
                Happiness-=2;
                Log.Insert(0,"Kirby did not like playing with you!");
                if(Happiness <= 0)
                {
                    isAlive = false;
                    Log.Insert(0,"Kirby left your boring ass!");
                }
            }
            else
            {
                Happiness+=rand.Next(5,11);
                Log.Insert(0,"Kirby enjoyed playing with you!");
                if(Energy >= 100 && Happiness >= 100 && Fullness >= 100)
                {
                    isAlive = false;
                    Log.Insert(0,"Kirby loves playing with you so much! Great job Kirby couldn't be happier!");
                }
            }
        }

        public void Work()
        {
            Energy -= 5;
            Random rand = new Random();
            Meals+=rand.Next(1,4);
            Log.Insert(0,"Kirby worked hard for some food.");
        }

        public void Sleep()
        {
            Energy+=15;
            Happiness-=5;
            Fullness-=5;
            if(Happiness <= 0 || Fullness <= 0)
            {
                isAlive = false;
                Log.Insert(0,"Kirby died in his sleep!");
            }
            else if(Energy >= 100 && Happiness >= 100 && Fullness >= 100)
            {
                isAlive = false;
                Log.Insert(0,"Kirby woke up happier then ever!");
            }
            else
            {
            Log.Insert(0,"Kirby had a good rest!");
            }
        }
    }
}