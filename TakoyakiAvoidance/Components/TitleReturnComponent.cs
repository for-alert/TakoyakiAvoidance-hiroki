using EngineGL.Impl;
using OpenTK.Input;
using TakoyakiAvoidance.Scenes;

namespace TakoyakiAvoidance.Components
{
    public class TitleReturnComponent : Component
    {
        private Game _game;

        public TitleReturnComponent(Game game)
        {
            _game = game;
        }

        public override void OnUpdate(double deltaTime)
        {
            base.OnUpdate(deltaTime);

            KeyboardState state = Keyboard.GetState();
            if (state.IsKeyDown(Key.BackSpace))
            {
                _game.LoadNextScene(new TitleScene(_game));
            }
        }
    }
}