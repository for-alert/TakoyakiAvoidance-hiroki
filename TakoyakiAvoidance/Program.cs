using System.Drawing;
using EngineGL.Impl;
using OpenTK;
using TakoyakiAvoidance.Scenes;

namespace TakoyakiAvoidance
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Game game = new GameBuilder()
                .SetTitle("スミス VS たこ焼き 大決戦")
                .SetIcon(new Icon("Images/takoyaki.ico", new Size(32, 32)))
                .SetClientSize(new Size(800, 600))
                .SetWindowBorder(WindowBorder.Fixed)
                .Build();
            game.Load += (sender, a) => game.LoadDefaultFunc();
            game.Resize += (sender, a) => game.AdjustResize();
            game.RenderFrame += (sender, a) => game.DrawDefaultFunc(a);

            game.LoadScene(new TitleScene(game));

            game.Run(60.0f);
        }
    }
}