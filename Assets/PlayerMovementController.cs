using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 1.0f;
        var y = Input.GetAxis("Vertical") * Time.deltaTime * 1.0f;

        transform.Translate(x, y, 0);
    }
}
