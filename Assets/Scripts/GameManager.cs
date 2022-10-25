using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int expectedNumber;
    public GameObject successPrefab;
    public GameObject failurePrefab;
    public TextMeshProUGUI text;

    private void OnEnable()
    {
        Events.OnPickUpEvent += CompareNumber;
    }

    private void OnDisable()
    {
        Events.OnPickUpEvent -= CompareNumber;
    }

    private void CompareNumber(int number)
    {
        if (expectedNumber == number)
        {
            Instantiate(successPrefab);
            text.text = number.ToString();
            StartCoroutine(DelaySceneChange("Level Two"));
        }
        else
        {
            Instantiate(failurePrefab);
            text.text = number.ToString();
            StartCoroutine(DelaySceneChange());

        }
    }

    IEnumerator DelaySceneChange(string sceneID = "")
    {
        if (sceneID != "")
        {
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(sceneID);
        }
        else
        {
            Scene scene = SceneManager.GetActiveScene();
            Debug.Log(scene.name);
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(scene.name);

        }
    }
}
