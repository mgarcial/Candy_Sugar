using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class Llaves : PickableItem
{
    [SerializeField] private controlPickable control;

    protected override void Pick(GameObject recolector)
    {
        control.Recogidos++;
    }
}
