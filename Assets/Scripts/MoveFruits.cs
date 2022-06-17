using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFruits : MonoBehaviour
{
    private float speed = 7f;
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
    }
}
