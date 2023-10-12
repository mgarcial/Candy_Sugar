using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using MoreMountains.Yo;

public class Monedas : PickableItem
{
    public int puntos = 10;

    [SerializeField] private controlPickable control;

    protected override void Pick(GameObject recolector)
    {
        CorgiEnginePointsEvent.Trigger(PointsMethods.Add, puntos);
        EventoPickable.Trigger(recolector.GetComponent<Character>(), recogibles.Moneda);
    }
}