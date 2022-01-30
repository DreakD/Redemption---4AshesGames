using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Haut Corp")]
    public Scrollbar sliderHautCorp;
    public Text hautCorpValueText;

    public void hautCorpValueChange()
    {
        hautCorpValueText.text = (sliderHautCorp.value *150).ToString();
    }
}
