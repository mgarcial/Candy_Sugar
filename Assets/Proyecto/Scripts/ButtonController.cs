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
        MMSceneLoadingManager.LoadScene("Dificultad");
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

    public void OnEasy()
    {
        GameManager.Instance.dificultad = Dificultad.Facil;
        MMSceneLoadingManager.LoadScene("Primer nivel");
    }

    public void OnMedium()
    {
        GameManager.Instance.dificultad = Dificultad.Medio;
        MMSceneLoadingManager.LoadScene("Primer nivel");
    }

    public void OnHard()
    {
        GameManager.Instance.dificultad = Dificultad.Dificil;
        MMSceneLoadingManager.LoadScene("Primer nivel");
    }
}
