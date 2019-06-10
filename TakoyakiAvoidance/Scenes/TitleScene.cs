using System.Drawing;
using EngineGL.Impl;
using EngineGL.Impl.Drawable;
using EngineGL.Impl.Objects;
using EngineGL.Structs.Math;
using TakoyakiAvoidance.Components;

namespace TakoyakiAvoidance.Scenes
{
    public class TitleScene : Scene
    {
        public TitleScene(Game game)
        {
            // オブジェクトを販売
            InitObjects(game);
        }

        public void InitObjects(Game game)
        {
            // スクリプト用のオブジェクト。
            GameObject titleEnterObject = new GameObject();
            // コンポーネントをアタッチ。
            titleEnterObject.AddComponent(new TitleEnterComponent(game));
            AddObject(titleEnterObject);

            // カメラの初期化
            StaticCamera camera = new StaticCamera();
            camera.SetPosition(new Vec3(0, 0, -10));
            AddObject(camera);

            // タイトルのテキスト
            // 色とフォントサイズ、テキストを指定
            TextRenderer titleObject = new TextRenderer(800, 100)
            {
                FontColor = Color.Red,
                FontSize = 35,
                Text = "スミス VS たこ焼き 大決戦"
            };
            titleObject
                .SetBounds(new Vec3(8, 1, 0))
                .SetPosition(new Vec3(-3.5f, 2, 0));
            AddObject(titleObject);

            // 'Press Enter..'のテキスト
            TextRenderer pressEnterObject = new TextRenderer(200, 100)
            {
                FontColor = Color.DarkRed,
                Text = "Press Enter..."
            };
            pressEnterObject
                .SetBounds(new Vec3(2, 1, 0))
                .SetPosition(new Vec3(-1f, -2, 0));
            AddObject(pressEnterObject);

            // バックグラウンドを配置
            RawTexture2D background = new RawTexture2D("Images/sky.png")
            {
                Layer = 1
            };
            background
                .SetBounds(new Vec3(15f, 10f))
                .SetPosition(new Vec3(-5.5f, -4.5f, 0));
            AddObject(background);
        }
    }
}