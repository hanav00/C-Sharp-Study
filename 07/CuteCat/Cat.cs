using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteCat
{
    public class Cat
    {
        public string Name;
        public int Age;
        private int Happiness = 50;

        public Cat(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public string Express()
        {
            string msg = "";

            if (Happiness >= 80) msg = "I'm very happy>_<";
            else if (Happiness >= 60) msg = "I'm happy :)";
            else if (Happiness >= 40) msg = "I'm soso.";
            else if (Happiness >= 20) msg = "I'm gloomy :(";
            else msg = "I'm so sad T^T";

            return this.Name + "*ฅ^•ﻌ•^ฅ* : " + msg;
        }

        public void Play()
        {
            Happiness += 10;
            if (Happiness > 100) Happiness = 100;
        }

        public void Feed()
        {
            Happiness += 10;
            if (Happiness > 100) Happiness = 100;
        }

        public void Bored()
        {
            Happiness -= 10;
            if (Happiness < 0) Happiness = 0;
        }
    }
}
