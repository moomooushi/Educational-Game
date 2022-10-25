using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour
{
    public delegate void PickUp(int number);

    public static PickUp OnPickUpEvent;
}
