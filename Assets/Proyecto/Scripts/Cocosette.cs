using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cocosette : Enemigos
{
    protected Collider2D boundsEnemigo;
    protected CorgiController jugador;
    protected bool jugadorEnRecuperacion = false;
    protected float tiempoRecuperacion = 0.3f;
    protected float timer;

    protected override void Initialization()
    {
        base.Initialization();
        boundsEnemigo = GetComponent<Collider2D>();
    }

    protected override void Update()
    {
        if (UpdateMode == UpdateModes.Update)
        {
            ExecuteUpdate();
        }

        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            jugadorEnRecuperacion = false;
        }
    }

    public override void OnTriggerEnter2D(Collider2D collider)
    {
        CorgiController controller = collider.GetComponent<CorgiController>();
        if (controller == null)
        {
            return;
        }

        jugador = controller;

        if(jugador.ColliderBottomPosition.y < boundsEnemigo.bounds.max.y)
        {
            // Le pegó por encima
            this.gameObject.SetActive(false);
        }
        else
        {
            // Fue herido por el enemigo
            if (!jugadorEnRecuperacion)
            {
                GameManager.Instance.LoseLife();
                jugadorEnRecuperacion = true;
                timer = tiempoRecuperacion;
            }
            
        }

    }
}
