using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Yo;
using System.Diagnostics.Tracing;
using MoreMountains.CorgiEngine;

public class controlPickable : MonoBehaviour, MMEventListener<EventoPickable>
{
    // Start is called before the first frame update
    [SerializeField] private int necesarios;
    [SerializeField] private int monedasParaVida;
    [SerializeField] private GameObject ActivableGameObject;

    [SerializeField] private int recogidos;
    private Character personaje;
    

    public int Recogidos
    {
        get { return recogidos; }
        set {recogidos = value; }
    }

    public Character Personaje
    {
        set { personaje = value; }
    }

    public virtual void OnMMEvent(EventoPickable e)
    {
        recogidos++;
        switch (e.tipoRecogible)
        {
            case recogibles.Llave:
                if (recogidos >= necesarios)
                {
                    ActivableGameObject.SetActive(true);
                }
                return;
            case recogibles.Moneda:
                if (recogidos == 1)
                {
                    ActivableGameObject.SetActive(true);
                    MMGameEvent.Trigger("VentanaMision");
                }
                if (recogidos >= necesarios)
                {
                    MMSceneLoadingManager.LoadScene("Segundo nivel");
                }
                if (recogidos == monedasParaVida)
                {
                    GameManager.Instance.GainLives(1);
                }
                return;
        }
    }

    void OnEnable()
    {
        this.MMEventStartListening<EventoPickable>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<EventoPickable>();
    }
}
