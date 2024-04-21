using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataParentManager : MonoBehaviour
{
    public List<PrefabReader> readers;
    public List<KatamariCharacter> charas;

    public Transform charaParent;
    public MeshRenderer boubouleRenderer;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < charas.Count; i++)
        {
            readers[i].Associate(charas[i],charaParent, boubouleRenderer);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
