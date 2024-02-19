using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Cartas : MonoBehaviour
{
    public int ptsPriv;
    public int ptsRecs;
    public int ptsSegu;
    public int ptsUser;
    public AudioSource somPassadaMouse;

    public static Cartas instance;

    public Cartas(int ptsPriv, int ptsRecs, int ptsSegu, int ptsUser)
    {
        instance = this;
        this.ptsPriv = ptsPriv;
        this.ptsRecs = ptsRecs;
        this.ptsSegu = ptsSegu;
        this.ptsUser = ptsUser;
        somPassadaMouse = GetComponent<AudioSource>();
    }

    public void OnMouseClick()
    {
        GameManager.pontosPrivacidade += this.ptsPriv;
        GameManager.pontosRecursos += this.ptsRecs;
        GameManager.pontosSeguranca += this.ptsSegu;
        GameManager.pontosUsuarios += this.ptsUser;

        Entidades.instance.PontuacaoEmTexto();
        Entidades.instance.ConfereGameOver();
    }

    public void PassadaDoMouse()
    {
        somPassadaMouse.Play();
    }
}
