using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.GameTemplate
{
    public class Chess : IGame
    {
        public bool isOver = false;
        public override bool GameOver
        {
            get { return isOver; }
        }

        public override void Play()
        {
            for(var i = 0; i < 10; i++)
            {
                Console.WriteLine("Game of Chess is being played");
            }
            isOver = true;
        }
    }
}
