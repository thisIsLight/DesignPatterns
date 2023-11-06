using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.GameTemplate
{
    //This is the template pattern. All the games will follow this
    public abstract class IGame
    {
        public virtual bool GameOver { get; }

        public void Run()
        {
            while (!GameOver)
            {
                Play();
            }
            Console.WriteLine("Game is Over now");
        }

        public abstract void Play();
    }
}
