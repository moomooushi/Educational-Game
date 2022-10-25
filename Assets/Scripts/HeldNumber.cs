using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeldNumber : MonoBehaviour
{
    public int number;
    public SpriteList sprites;
    public SpriteRenderer sr;

    private void Start()
    {
        if (number <= sprites.list.Count)
        {
            sr = GetComponent<SpriteRenderer>();
            sr.sprite = sprites.list[number - 1];

            Debug.Log(sprites.list.Count);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Events.OnPickUpEvent?.Invoke(number);
        Destroy(gameObject);
    }
}
