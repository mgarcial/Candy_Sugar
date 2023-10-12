using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using MoreMountains.Yo;

public class Vida : Health, MMEventListener<EventoCambiarVida>
{
    public void OnMMEvent(EventoCambiarVida e)
    {
        switch (e.tipoAccion)
        {
            case AccionCambioVida.Añadir:
                GameManager.Instance.GainLives(e.cantidad);
                break;
            case AccionCambioVida.Quitar:
                break;
            case AccionCambioVida.Setear:
                break;
        }
    }
}
