using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    private static bool volume;
    public Sprite somOnBt;
    public Sprite somOffBt;
    public Button botao;

    public void SetVolume()
    {
        volume = !volume;

        if (volume)
        {
            AudioListener.volume = 1;
            botao.image.sprite = somOnBt;
        }
        else
        {
            AudioListener.volume = 0;
            botao.image.sprite = somOffBt;
        }
    }
}
