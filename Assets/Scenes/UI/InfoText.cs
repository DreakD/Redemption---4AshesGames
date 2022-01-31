using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoText : MonoBehaviour
{
    public Text infoBulle;

    void OnMouseOver(Collider collider)
    {
        infoBulle.text = collider.name;
        Debug.Log("touche slider");
    }
}
