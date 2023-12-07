using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class EnemyController : MonoBehaviour
{
    public float speed;
    public Text CountText;
    public bool vertical;
    public float changeTime = 3.0f;

    Rigidbody2D rigidbody2D;
    int count; 
    float timer;
    int direction = 1;
    Animator animator;
    bool broken = true;
    public ParticleSystem smokeEffect;
    public bool fixingDone;
    public int fixValue = 1;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        fixingDone = false;

        timer = changeTime;

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!broken)
        {
            return;
        }

        timer -= Time.deltaTime;

        if(timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }
    }


    void FixedUpdate()
    {
        if(!broken)
        {
            return;
        }
        
        Vector2 position = rigidbody2D.position;

        if(vertical)
        {
            position.y = position.y + Time.deltaTime * speed * direction;
            animator.SetFloat("MoveX", 0);
            animator.SetFloat("MoveY", direction);
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed * direction;
            animator.SetFloat("MoveX", direction);
            animator.SetFloat("MoveY", 0);
        }

        rigidbody2D.MovePosition(position);
        
        
    }
    public void SetCountText(int fixValue) 
   {
       count += fixValue;
       CountText.text = "Fixed Robots: "+count.ToString();
       if (count >=1)
       {
            fixingDone = true;
       }
   }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        RubyController player = other.gameObject.GetComponent<RubyController>();
        

        if(player != null)
        {
            player.ChangeHealth(-1);
        }
    }

    public void Fix()
    {
        broken = false;
        rigidbody2D.simulated = false;
        animator.SetTrigger("Fixed");
        SetCountText(fixValue);
        smokeEffect.Stop();
    }

}
    