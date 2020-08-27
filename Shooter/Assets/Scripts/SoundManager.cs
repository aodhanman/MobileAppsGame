using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip playerHitSound, shootSound, enemyHitSound;
    static AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        playerHitSound = Resources.Load<AudioClip> ("fireball-01");
        shootSound = Resources.Load<AudioClip> ("Laser");
        enemyHitSound = Resources.Load<AudioClip> ("explosion2");

        audioSource = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip){
        switch (clip){
            case "shot":
                audioSource.PlayOneShot (shootSound);
                break;
            case "playerHit":
                audioSource.PlayOneShot (playerHitSound);
                break;
            case "enemyHit":
                audioSource.PlayOneShot (enemyHitSound);
                break;

        }
    }
}
