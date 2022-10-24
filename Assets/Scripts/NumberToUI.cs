using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberToUI : MonoBehaviour
{
    public TMP_Text text;

    private void OnTriggerEnter2D(Collider other)
    {
        if (other.tag == "Player")
        {
            // text.text = GameObject.Find()
        }
    }
}
