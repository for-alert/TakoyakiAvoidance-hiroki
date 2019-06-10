using EngineGL.Impl;
using EngineGL.Structs.Math;

namespace TakoyakiAvoidance.Components.GamePlay
{
    public class TakoyakiFallComponent : Component
    {
        public override void OnUpdate(double deltaTime)
        {
            base.OnUpdate(deltaTime);

            GameObject.Transform.Position += Vec3.Down * (float) deltaTime;
        }
    }
}