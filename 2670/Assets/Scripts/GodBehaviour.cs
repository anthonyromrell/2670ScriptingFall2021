using UnityEngine;

public class GodBehaviour : MonoBehaviour
{
    public ParticleSystem particleSystemObj;

    public void RunParticleSystem()
    {
        particleSystemObj.Emit(100);
    }
}
