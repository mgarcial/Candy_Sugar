using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;


public class Enemigos : AIBrain, Respawnable, MMEventListener<CorgiEngineEvent>
{
    public bool ResetPositionWhenPlayerRespawns = true;

    public virtual void OnTriggerEnter2D(Collider2D collider)
    {
        CorgiController controller = collider.GetComponent<CorgiController>();
        if (controller == null)
        {
            return;
        }

    }


    public virtual void OnPlayerRespawn(CheckPoint checkpoint, Character player)
    {
        if (ResetPositionWhenPlayerRespawns)
        {
            
        }
    }

    public virtual void OnMMEvent(CorgiEngineEvent eventType)
    {
        if (eventType.EventType == CorgiEngineEventTypes.Respawn)
        {
            if (ResetPositionWhenPlayerRespawns)
            {
                
            }
        }
    }

    /// <summary>
    /// On enable, starts listening for CorgiEngine events
    /// </summary>
    protected virtual void OnEnable()
    {
        this.MMEventStartListening<CorgiEngineEvent>();
    }

    /// <summary>
    /// On disable, stops listening for CorgiEngine events
    /// </summary>
    protected virtual void OnDisable()
    {
        this.MMEventStopListening<CorgiEngineEvent>();
    }
}
