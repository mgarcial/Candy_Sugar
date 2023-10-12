using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using MoreMountains.Yo;

public class Llaves : PickableItem
{
    [SerializeField] private controlPickable control;

    protected override void Pick(GameObject recolector)
    {
        EventoPickable.Trigger(this._character, recogibles.Llave);
    }
}
