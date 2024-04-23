using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class KatamariCharacter : ScriptableObject   
{
    public string charaName;
    public GameObject characterMesh;
    public Material materialForKatamari;
    public Sprite iconSprite;
    public AudioClip voiceAnouncement;
}
