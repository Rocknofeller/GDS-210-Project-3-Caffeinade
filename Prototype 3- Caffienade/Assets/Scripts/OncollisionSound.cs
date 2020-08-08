using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncollisionSound : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        //this is only for the sound when it hits game object

        if (other.gameObject.tag == "Player")
        {
            AudioManager.PlaySound("Cash");
        }
        
    }
}
