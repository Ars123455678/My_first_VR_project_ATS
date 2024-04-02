using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundComponent : MonoBehaviour
{
    [SerializeField] private SoundPrefab soundPrefab;
    [SerializeField] private float volumeFactor;    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundPrefab sound = Instantiate(soundPrefab);
        sound.Play(collision.relativeVelocity.magnitude); 
    }
}
