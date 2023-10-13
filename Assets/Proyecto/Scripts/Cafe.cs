using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Yo;
using MoreMountains.Tools;

public class Café : Enemigos, MMEventListener<EventoEnemigo>
{

    public override void OnTriggerEnter2D(Collider2D collider)
    {
        CorgiController controller = collider.GetComponent<CorgiController>();
        if (controller == null)
        {
            return;
        }

        GameManager.Instance.LoseLife();
    }

    public void OnMMEvent(EventoEnemigo e)
    {
        switch (e.nombre)
        {
            case "Matar Cafe":
                this.gameObject.SetActive(false);
                break;
        }
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        this.MMEventStartListening<EventoEnemigo>();
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        this.MMEventStopListening<EventoEnemigo>();
    }
}
