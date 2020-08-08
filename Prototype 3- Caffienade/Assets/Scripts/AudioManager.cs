using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //all the sound effects except background music

    

    public static AudioClip Cash, floorClip, clickTwo, floorBall, clickOne, giggles;
    static AudioSource beep;
    void Start()
    {
        Cash = Resources.Load<AudioClip>("CashRegister");
        floorClip = Resources.Load<AudioClip>("floor");
        clickTwo = Resources.Load<AudioClip>("click2");
        clickOne = Resources.Load<AudioClip>("click1");
        floorBall = Resources.Load<AudioClip>("ball");

        beep = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "CashRegister":
                beep.PlayOneShot(Cash);
                break;

            case "floor":
                beep.PlayOneShot(floorClip);
                break;

            case "click2":
                beep.PlayOneShot(clickTwo);
                break;

            case "click1":
                beep.PlayOneShot(clickOne);
                break;

            case "ball":
                beep.PlayOneShot(floorBall);
                break;


        }
    }
}
