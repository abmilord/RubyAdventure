using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUpEffects powerUpeffect;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        powerUpeffect.Apply(collision.gameObject);
    }
}
