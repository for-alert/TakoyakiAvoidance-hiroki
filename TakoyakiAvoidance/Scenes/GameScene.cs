using System.Drawing;
using EngineGL.Impl;
using EngineGL.Impl.Drawable;
using EngineGL.Impl.Objects;
using EngineGL.Structs.Math;
using TakoyakiAvoidance.Components.GamePlay;

namespace TakoyakiAvoidance.Scenes
{
    public class GameScene : Scene
    {
        public GameScene(Game game)
        {
            // オブジェクトを配置
            InitObjects(game);
        }

        public void InitObjects(Game game)
        {
            // カメラの初期化
            StaticCamera camera = new StaticCamera();
            camera.SetPosition(new Vec3(0, 0, -10));
            AddObject(camera);

            // バックグラウンドを配置
            RawTexture2D background = new RawTexture2D("Images/sky.png")
            {
                Layer = 1
            };
            background
                .SetBounds(new Vec3(15f, 10f))
                .SetPosition(new Vec3(-5.5f, -4.5f, 0));
            AddObject(background);

            // プレイヤーを配置
            RawTexture2D player = new RawTexture2D("Images/smith.png");
            player
                .SetBounds(new Vec3(.8f, 1.3f, 0))
                .SetPosition(new Vec3(-0.5f, -3.0f, 0));
            player.AddComponent(new PlayerComponent(game));
            AddObject(player);

            TextRenderer renderer = new TextRenderer(200, 100)
            {
                FontColor = Color.Red
            };
            renderer
                .SetBounds(new Vec3(2, 1, 0))
                .SetPosition(new Vec3(-3f, 3f, 0));
            AddObject(renderer);

            // スクリプト用オブジェクト
            GameObject components = new GameObject();
            components.AddComponent(new RandomSpawnerComponent());
            components.AddComponent(new TimerComponent(game, renderer));
            AddObject(components);
        }
    }
}