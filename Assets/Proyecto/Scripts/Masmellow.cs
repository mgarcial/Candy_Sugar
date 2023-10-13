using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Masmellow : Enemigos
{
    protected int vidas = 3;

    public override void OnTriggerEnter2D(Collider2D collider)
    {
        CorgiController controller = collider.GetComponent<CorgiController>();
        if (controller == null)
        {
            return;
        }

        vidas--;

        if (vidas < 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
