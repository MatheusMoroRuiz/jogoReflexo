using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Jogo
{
    class clsJogo
    {
        public int newX, newY;
        public string email = "matheus@gmail.com";

        public int RandomizarX()
        {
            Random randX = new Random();
                newX = (randX.Next(11, 625));

            return newX;
        }

        public int RandomizarY()
        {
            Random randY = new Random();
                newY = (randY.Next(122, 499));

            return newY;
        }

    }
}
