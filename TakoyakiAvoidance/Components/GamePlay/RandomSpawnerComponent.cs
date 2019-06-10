using System;
using EngineGL.Impl;
using EngineGL.Impl.Drawable;
using EngineGL.Structs.Math;
using EngineGL.Utils;

namespace TakoyakiAvoidance.Components.GamePlay
{
    public class RandomSpawnerComponent : Component
    {
        private Random _random;
        private int _tick;

        public override void OnInitialze()
        {
            base.OnInitialze();

            _random = LocalThreadRandom.GetRandom();
        }

        public override void OnUpdate(double deltaTime)
        {
            base.OnUpdate(deltaTime);

            if (_tick % 60 == 0)
            {
                Vec3 pos = new Vec3(_random.Next(-5, 5),
                    5, 0);

                RawTexture2D takoyaki = new RawTexture2D("Images/takoyaki.png")
                {
                    Tag = "Takoyaki",
                    Layer = 0
                };
                takoyaki
                    .SetBounds(new Vec3(1, 1, 0))
                    .SetPosition(pos);
                takoyaki.AddComponentUnsafe<TakoyakiFallComponent>();
                takoyaki.AddComponentUnsafe<TakoyakiRemoveComponent>();
                GameObject.Scene.AddObject(takoyaki);
            }

            _tick++;
        }
    }
}