using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private BoxCollider2D target;
    [SerializeField] private AudioClip targetDestroyedSoundEffect;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("target"))
        {
            AudioSource.PlayClipAtPoint(targetDestroyedSoundEffect, gameObject.transform.position, 1);
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}
