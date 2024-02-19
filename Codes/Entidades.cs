using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Entidades : MonoBehaviour //Script atribuído no ScriptPct na engine
{
    //public int startPontuacao = 50;
    public int pontuacaoPrivacidade;
    public TextMesh pontuacaoPrivacidadeStr;
    public int pontuacaoRecursos;
    public TextMesh pontuacaoRecursosStr;
    public int pontuacaoSeguranca;
    public TextMesh pontuacaoSegurancaStr;
    public int pontuacaoUsuarios;
    public TextMesh pontuacaoUsuariosStr;
    
    public static Entidades instance;
    private int diferenca;
    private int indexCenaDaVez = 0;

    private bool derrotaPriv0 = false;
    private bool derrotaRecs0 = false;
    private bool derrotaSegu0 = false;
    private bool derrotaUser0 = false;

    private bool derrotaPriv100 = false;
    private bool derrotaRecs100 = false;
    private bool derrotaUser100 = false;

    public void Start()
    {
        instance = this;
;       this.PontuacaoEmTexto();
    }

    public void ConfereGameOver()
    {
        if (this.pontuacaoSeguranca >= 100)
        {
            diferenca = this.pontuacaoSeguranca - 100;
            GameManager.pontosSeguranca = this.pontuacaoSeguranca -= diferenca;
            this.PontuacaoEmTexto();
        }
        
        if (this.pontuacaoPrivacidade <= 0)
        {
            diferenca = 0 - this.pontuacaoPrivacidade;
            GameManager.pontosPrivacidade = this.pontuacaoPrivacidade += diferenca;
            this.PontuacaoEmTexto();
            derrotaPriv0 = true;
        }
        
        if (this.pontuacaoPrivacidade >= 100)
        {
            diferenca = this.pontuacaoPrivacidade - 100;
            GameManager.pontosPrivacidade = this.pontuacaoPrivacidade -= diferenca;
            this.PontuacaoEmTexto();
            derrotaPriv100 = true;
        }
        
        if (this.pontuacaoRecursos <= 0)
        {
            diferenca = 0 - this.pontuacaoRecursos;
            GameManager.pontosRecursos = this.pontuacaoRecursos += diferenca;
            this.PontuacaoEmTexto();
            derrotaRecs0 = true;
        }
        
        if (this.pontuacaoRecursos >= 100)
        {
            diferenca = this.pontuacaoRecursos - 100;
            GameManager.pontosRecursos = this.pontuacaoRecursos -= diferenca;
            this.PontuacaoEmTexto();
            derrotaRecs100 = true;
        }
        
        if (this.pontuacaoSeguranca <= 0)
        {
            diferenca = 0 - this.pontuacaoSeguranca;
            GameManager.pontosSeguranca = this.pontuacaoSeguranca += diferenca;
            this.PontuacaoEmTexto();
            derrotaSegu0 = true;
        }
        
        if (this.pontuacaoUsuarios <= 0)
        {
            diferenca = 0 - this.pontuacaoUsuarios;
            GameManager.pontosUsuarios = this.pontuacaoUsuarios += diferenca;
            this.PontuacaoEmTexto();
            derrotaUser0 = true;
        }
        
        if (this.pontuacaoUsuarios >= 100)
        {
            diferenca = this.pontuacaoUsuarios - 100;
            GameManager.pontosUsuarios = this.pontuacaoUsuarios -= diferenca;
            this.PontuacaoEmTexto();
            derrotaUser100 = true;
        }

        if(derrotaPriv0)
        {
            NextScene.instance.Derrota("Priv0-TelaDerrota");
        }
        else if(derrotaPriv100)
        {
            NextScene.instance.Derrota("Priv100-TelaDerrota");
        }
        else if(derrotaRecs0)
        {
            NextScene.instance.Derrota("Recs0-TelaDerrota");
        }
        else if(derrotaRecs100)
        {
            NextScene.instance.Derrota("Recs100-TelaDerrota");
        }
        else if(derrotaSegu0)
        {
            NextScene.instance.Derrota("Seg0-TelaDerrota");
        }
        else if(derrotaUser0)
        {
            NextScene.instance.Derrota("User0-TelaDerrota");
        }
        else if(derrotaUser100)
        {
            NextScene.instance.Derrota("User100-TelaDerrota");
        }
        else
        {
            indexCenaDaVez++;
            Debug.Log(indexCenaDaVez);

            if(indexCenaDaVez <= 9)
            {
                NextScene.instance.AvancarAleatoriamente(indexCenaDaVez);
            }
            else
            {
                NextScene.instance.Vitoria();
            }
        }
    }

    public void PontuacaoEmTexto()
    {
        this.pontuacaoPrivacidade = GameManager.pontosPrivacidade;
        this.pontuacaoPrivacidadeStr.text = this.pontuacaoPrivacidade.ToString() + "%"; 
        
        this.pontuacaoRecursos = GameManager.pontosRecursos;
        this.pontuacaoRecursosStr.text = this.pontuacaoRecursos.ToString() + "%";
        
        this.pontuacaoSeguranca = GameManager.pontosSeguranca;
        this.pontuacaoSegurancaStr.text = this.pontuacaoSeguranca.ToString() + "%";
        
        this.pontuacaoUsuarios = GameManager.pontosUsuarios;
        this.pontuacaoUsuariosStr.text = this.pontuacaoUsuarios.ToString() + "%";
    }
}
