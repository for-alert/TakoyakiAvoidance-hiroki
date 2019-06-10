using EngineGL.Core;
using EngineGL.Impl;
using EngineGL.Impl.Components;
using EngineGL.Structs.Math;
using OpenTK.Input;
using TakoyakiAvoidance.Scenes;

namespace TakoyakiAvoidance.Components.GamePlay
{
    public class PlayerComponent : Collision2D
    {
        private Game _game;

        public PlayerComponent(Game game)
        {
            _game = game;
        }

        public override void OnUpdate(double deltaTime)
        {
            base.OnUpdate(deltaTime);

            KeyboardState state = Keyboard.GetState();
            if (state[Key.A])
            {
                if (GameObject.Transform.Position.X >= -5)
                    GameObject.Transform.Position += Vec3.Left * (float) deltaTime * 2;
            }

            if (state[Key.D])
            {
                if (GameObject.Transform.Position.X <= 4)
                    GameObject.Transform.Position += Vec3.Right * (float) deltaTime * 2;
            }
        }

        public override void OnCollisionEnter(IGameObject gameObject)
        {
            base.OnCollisionEnter(gameObject);

            if (gameObject.Tag == "Takoyaki")
            {
                _game.LoadNextScene(new ResultScene(_game, "ゲームオーバー!!"));
            }
        }
    }
}