using EngineGL.Impl;
using EngineGL.Impl.Drawable;
using TakoyakiAvoidance.Scenes;

namespace TakoyakiAvoidance.Components.GamePlay
{
    public class TimerComponent : Component
    {
        private const int MaxTime = 60 * 60;
        private int _timer = MaxTime;
        private Game _game;
        private TextRenderer _textRenderer;

        public TimerComponent(Game game, TextRenderer renderer)
        {
            _game = game;
            _textRenderer = renderer;
        }

        public override void OnUpdate(double deltaTime)
        {
            base.OnUpdate(deltaTime);

            _textRenderer.Text = $"Time: {_timer / 60}";
            if (_timer <= 0)
            {
                _game.LoadNextScene(new ResultScene(_game, "ゲームクリア！"));
            }

            _timer--;
        }
    }
}