using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Haut Corp")]
    public Scrollbar sliderHautCorp;
    public Text hautCorpValueText;
    [Header("Bas Corp")]
    public Scrollbar sliderBasCorp;
    public Text basCorpValueText;
    [Header("Age")]
    public Scrollbar sliderAge;
    public Text ageValueText;


    private void Start()
    {
        hautCorpValueText.text = Math.Floor((sliderHautCorp.value * 150)).ToString();
        basCorpValueText.text = Math.Floor((sliderBasCorp.value * 150)).ToString();
        ageValueText.text = Math.Floor((sliderAge.value * 150)).ToString();
    }

    public void hautCorpValueChange()
    {
        hautCorpValueText.text = Math.Floor((sliderHautCorp.value * 150)).ToString();
    }

    public void basCorpValueChange()
    {
        basCorpValueText.text = Math.Floor((sliderBasCorp.value * 150)).ToString();
    }

    public void ageValueChange()
    {
        ageValueText.text = Math.Floor((sliderAge.value * 150)).ToString();
    }
}
