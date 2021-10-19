using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.transform.Rotate(new Vector3(10f, 0f, 0f));
        }
    }
}
