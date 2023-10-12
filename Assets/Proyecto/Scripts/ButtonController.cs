using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class ButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnJugar()
    {
        Debug.Log("Click Jugar");
        MMSceneLoadingManager.LoadScene("Primer nivel");
    }

    public void OnInstrucciones()
    {
        Debug.Log("Click Instru");
        MMSceneLoadingManager.LoadScene("Instrucciones");
    }

    public void OnCreditos()
    {
        Debug.Log("Click Creditos");
        MMSceneLoadingManager.LoadScene("Creditos");
    }

    public void Onvolver()
    {
        Debug.Log("Click Volver");
        MMSceneLoadingManager.LoadScene("Home");
    }
}
