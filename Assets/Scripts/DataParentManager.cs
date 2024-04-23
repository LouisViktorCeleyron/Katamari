using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DataParentManager : MonoBehaviour
{
    public List<PrefabReader> readers;
    public List<KatamariCharacter> charas;

    public Transform charaParent;
    public MeshRenderer boubouleRenderer;
    public TextMeshProUGUI text;

    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < charas.Count; i++)
        {
            readers[i].Associate(charas[i],charaParent, boubouleRenderer,text,audioSource);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
