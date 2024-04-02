using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPrefab : MonoBehaviour
{
    [SerializeField] private AudioSource sound;
    [SerializeField] private float volumeFactor = 1;
    [SerializeField] private float lifeTime = 1f;

    public void Play(float volume)
    { 
        sound.pitch = Random.Range(1f, 1f);
        sound.volume *= volume * volumeFactor;
    }

    private void Update()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime < 0)
            Destroy(gameObject);
    }
}
