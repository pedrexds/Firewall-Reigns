using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    private static int[] indexCenas = {2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
    public static int[] ordemFases;
    public static NextScene instance;

    public NextScene()
    {
        instance = this;
        ordemFases = AleatorizadorDeFases(indexCenas);
    }

    public int[] AleatorizadorDeFases(int[] vet)
    {
        System.Random rand = new System.Random();

        for (int i = vet.Length - 1; i >= 1; i--)
        {
            int j = rand.Next(0, i + 1);
            int temp = vet[i];
            vet[i] = vet[j];
            vet[j] = temp;
        }

        return vet;
    }

    public void AvancarAleatoriamente(int index)
    {
        if(SceneManager.GetActiveScene().buildIndex != 1)
        {
            SceneManager.LoadScene(ordemFases[index]);
        }
        else
        {
            SceneManager.LoadScene(ordemFases[0]);
        }
    }

    public void Update()
    {
        bool getBt = Input.GetKey(KeyCode.Space);

        if((getBt)&&(SceneManager.GetActiveScene().buildIndex == 0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void AvancarCreditos()
    {
        if (SceneManager.GetActiveScene().buildIndex == 13)
        {
            SceneManager.LoadScene("TelaDeCreditos2");
        }
        else
        {
            SceneManager.LoadScene("TelaDeCreditos");
        }
    }

    public static void VoltarNovoJogo()
    {
        SceneManager.LoadScene("TelaInicial");
        GameManager.instance.ShutDown();
    }

    public void SairDoJogo()
    {
        SceneManager.LoadScene("ConfirmarSaida");
    }

    public void EncerrarJogo()
    {
        Application.Quit();
    }

    public void Derrota(string nomeDaCena)
    {
        SceneManager.LoadScene(nomeDaCena);
    }

    public void Vitoria()
    {
        SceneManager.LoadScene("TelaVitoria");
    }
}
