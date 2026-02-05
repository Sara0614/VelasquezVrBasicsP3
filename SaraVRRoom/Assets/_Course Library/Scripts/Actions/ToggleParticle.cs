using UnityEngine;

public class ToggleParticle : MonoBehaviour
{
    public ParticleSystem particle;

    public void Play()
    {
        if (particle != null && !particle.isPlaying)
            particle.Play();
    }

    public void Stop()
    {
        if (particle != null && particle.isPlaying)
            particle.Stop();
    }
}

