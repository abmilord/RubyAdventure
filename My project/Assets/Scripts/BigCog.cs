using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Powerups/BigCog")]
public class BigCog : PowerUpEffects
{
    public override void Apply(GameObject other)
    {
        other.GetComponent<RubyController>();
    }
}
