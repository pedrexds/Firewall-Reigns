using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int pontosPrivacidade = 50;
    public static int pontosRecursos = 50;
    public static int pontosSeguranca = 50;
    public static int pontosUsuarios = 50;
    public static GameManager instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(instance !=  this)
        {
            Destroy(gameObject);
        }
    }

    public void ShutDown()
    {
        Destroy(gameObject);
        pontosPrivacidade = pontosRecursos = pontosSeguranca = pontosUsuarios = 50;
    }
}
