using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconSpawner : MonoBehaviour
{

    public GameObject icon;

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(icon, transform.position, transform.rotation);

        }
    }
}
