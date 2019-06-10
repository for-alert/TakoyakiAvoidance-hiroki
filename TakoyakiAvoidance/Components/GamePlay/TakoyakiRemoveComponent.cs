using EngineGL.Impl;

namespace TakoyakiAvoidance.Components.GamePlay
{
    public class TakoyakiRemoveComponent : Component
    {
        public override void OnUpdate(double deltaTime)
        {
            base.OnUpdate(deltaTime);

            if (GameObject.Transform.Position.Y <= -5)
            {
                GameObject.Scene.RemoveObject(GameObject);
            }
        }
    }
}