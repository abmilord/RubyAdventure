using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//whole script by Abiola
public class PoisonHealth : MonoBehaviour
{
     public AudioClip collectedClip;
   
   void OnTriggerEnter2D(Collider2D other)
   {
    RubyController controller = other.GetComponent<RubyController>();

    if(controller != null)
    {
        
      controller.Poisoned(-3);
      Destroy(gameObject);

      controller.PlaySound(collectedClip);
    
        
    }
   }
}
