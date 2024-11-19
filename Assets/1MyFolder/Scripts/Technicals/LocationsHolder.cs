using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationsHolder : MonoBehaviour
{
    public static LocationsHolder Instance;
    public GameObject SchoolLocationButton;
    private void Awake()
    {
        if (Instance == null) { Instance = this; }
        else Destroy(this);
    }
}
