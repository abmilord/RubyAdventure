using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//whole script by Abiola
public class CogCollectible : MonoBehaviour
{
    public float duration = 3.0f;

    private Collider2D _collider;

    public AudioClip collectedClip;

    private void Awake()
    {
        _collider = GetComponent<Collider2D>();
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if(controller != null)
        {
            StartCoroutine(Pickup(controller));
            
            controller.PlaySound(collectedClip);
        }
    }

    public IEnumerator Pickup(RubyController controller)
    {
        GetComponent<SpriteRenderer>().enabled = false;
        _collider.enabled = false;

        ActivatePower(controller);

        yield return new WaitForSeconds(10);

        DeactivatePower(controller);

        Debug.Log("picked up");
        Destroy(gameObject);
    }

    private void ActivatePower(RubyController controller)
    {
        controller.projectilePrefab = controller.projectilePrefab2;
    }

    private void DeactivatePower(RubyController controller)
    {
        controller.projectilePrefab2 = controller.projectilePrefab;
    }
}
