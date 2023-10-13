using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlVenta : MonoBehaviour, MMEventListener<MMGameEvent>
{

    private void Start()
    {
        this.gameObject.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetAxis("Player1_Shoot") > 0)
        {
            BotonCerrar();
        }
    }

    public void BotonCerrar()
    {
        StartCoroutine(CerrarVentana(2));
    }

    public virtual void OnMMEvent(MMGameEvent e)
    {
        switch (e.EventName)
        {
            case ("VentanaMision"):
                StartCoroutine(AbrirVentana(2));
                break;
        }
    }

    void OnEnable()
    {
        this.MMEventStartListening<MMGameEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<MMGameEvent>();
    }

    IEnumerator AbrirVentana(int seg)
    {
        GameManager.Instance.Pause(PauseMethods.NoPauseMenu);
        yield return new WaitForSeconds(seg);
    }

    IEnumerator CerrarVentana(int seg)
    {
        GameManager.Instance.UnPause(PauseMethods.NoPauseMenu);
        this.gameObject.SetActive(false);
        yield return new WaitForSeconds(seg);
    }
}
