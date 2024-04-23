using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotator : MonoBehaviour
{
    [SerializeField]
    private float baseSpeed;
    private float speed;
    [SerializeField]
    private bool horizontal, vertical, depth, acceleration,freemode,resetable=true;

    private Vector3 _mouseFramePos;

    private bool _wasClicked;

    private void Start()
    {
        speed = baseSpeed;
    }

    void Update()
    {
        if(freemode)
        {
            if (Input.GetMouseButtonUp(1))
            {
                _wasClicked = false;
            }

            if (Input.GetMouseButton(1))
            {
                if(!_wasClicked)
                {
                    _wasClicked = true;
                    _mouseFramePos = Input.mousePosition;
                }
                var _delta = _mouseFramePos - Input.mousePosition;
                transform.Rotate( new Vector3(_delta.y,_delta.x,0) * speed);
                _mouseFramePos = Input.mousePosition;

                return;
            }

        }
        if(Input.GetMouseButton(2))
        {
            transform.eulerAngles = Vector3.zero;
            speed = baseSpeed;

        }
        transform.Rotate((Vector3.up * (horizontal ? 1 : 0) + Vector3.left * (vertical ? 1 : 0) + Vector3.forward* (depth? 1 : 0)) * speed);
    }


    private void OnMouseDown()
    {

        if(Input.GetMouseButtonDown(0))
        {
            speed = Mathf.Clamp(speed + 0.2f, 0, 5.2f);
            if(speed >= 5.1f)
            {
                speed = 0f;
            }
        }
    }
}
