using System.Drawing;
using EngineGL.Impl;
using EngineGL.Impl.Drawable;
using EngineGL.Impl.Objects;
using EngineGL.Structs.Math;
using TakoyakiAvoidance.Components;

namespace TakoyakiAvoidance.Scenes
{
    public class ResultScene : Scene
    {
        public ResultScene(Game game, string text)
        {
            InitObjects(game, text);
        }

        public void InitObjects(Game game, string text)
        {
            GameObject titleReturnObject = new GameObject();
            titleReturnObject.AddComponent(new TitleReturnComponent(game));
            AddObject(titleReturnObject);

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

            // タイトルのテキスト
            // 色とフォントサイズ、テキストを指定
            TextRenderer titleObject = new TextRenderer(800, 100)
            {
                FontColor = Color.Red,
                FontSize = 35,
                Text = text
            };
            titleObject
                .SetBounds(new Vec3(8, 1, 0))
                .SetPosition(new Vec3(-3.5f, 2, 0));
            AddObject(titleObject);

            // 'Press Enter..'のテキスト
            TextRenderer pressEnterObject = new TextRenderer(200, 100)
            {
                FontColor = Color.DarkRed,
                Text = "Press BackSpace..."
            };
            pressEnterObject
                .SetBounds(new Vec3(2, 1, 0))
                .SetPosition(new Vec3(-1f, -2, 0));
            AddObject(pressEnterObject);
        }
    }
}