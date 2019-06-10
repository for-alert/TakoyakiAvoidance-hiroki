using EngineGL.Impl;
using OpenTK.Input;
using TakoyakiAvoidance.Scenes;

namespace TakoyakiAvoidance.Components
{
    public class TitleEnterComponent : Component
    {
        private Game _game;

        public TitleEnterComponent(Game game)
        {
            _game = game;
        }

        public override void OnUpdate(double deltaTime)
        {
            base.OnUpdate(deltaTime);

            KeyboardState state = Keyboard.GetState();
            if (state.IsKeyDown(Key.Enter))
            {
                _game.LoadNextScene(new GameScene(_game));
            }
        }
    }
}