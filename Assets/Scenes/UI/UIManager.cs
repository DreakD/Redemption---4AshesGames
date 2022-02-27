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

    [Header("Description")]
    public Text descriptionStatsText;


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

    public void descriptionStat(String type)
    {
        switch (type)
        {
            case "haut":
                descriptionStatsText.text = "Le haut du corps, relatif au épaule, au bras et au torse," +
                    " symbolisant les valeur de force, de point de vie et de Défense.";
                break;
            case "bas":
                descriptionStatsText.text = "Le bas du corps, relatif au jambes, symbolisant" +
                    " la valeur de rapidité de déplacements et d'attaque, ainsi que l'endurance.";
                break;
            case "age":
                descriptionStatsText.text = "L'Age, relatif au Mana et a l'attaque/défense magique.";
                break;
        }
    }
}
