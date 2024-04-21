using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotator : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private bool horizontal,vertical;

    void Update()
    {
        transform.Rotate((Vector3.up * (horizontal ? 1 : 0) + Vector3.left * (vertical ? 1 : 0))*speed);
    }
}
