using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlVenta : MonoBehaviour, MMEventListener<MMGameEvent>
{
    bool cerrar;

    private void Start()
    {
        cerrar = false;
        this.gameObject.SetActive(false);
    }

    public void BotonCerrar()
    {
        cerrar = true;
    }

    public virtual void OnMMEvent(MMGameEvent e)
    {
        switch (e.EventName)
        {
            case ("VentanaMision"):
                StartCoroutine(CerrarVentana());
                break;
        }
    }

    IEnumerator CerrarVentana()
    {
        GameManager.Instance.Pause(PauseMethods.NoPauseMenu);
        yield return new WaitUntil(() => cerrar = true);
        this.gameObject.SetActive(false);
    }
}
