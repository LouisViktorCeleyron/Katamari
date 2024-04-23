using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpColor : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Color[] colors;
    private float _t;
    public float speed;
    private int i;
    private int iPlus = 1;
    // Update is called once per frame
    void Update()
    {
        _t += Time.deltaTime*speed;
        if(_t>=1)
        {
            _t = 0;
            i = i + 1 >= colors.Length ? 0 : i + 1; ;
            iPlus =  i+1 >= colors.Length ? 0 : i+1;
        }

        spriteRenderer.color = Color.Lerp(colors[i], colors[iPlus], _t);

    }
}
