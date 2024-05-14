using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrefabReader : MonoBehaviour
{
    public KatamariCharacter associatedCharacter;
    public Image buttonIcon;

    private TextMeshProUGUI _text;
    private Transform _charaContainer;
    private MeshRenderer _meshFilterBouboule;
    private AudioSource _source;
    private AudioClip _defaultClip;

    public void Associate(KatamariCharacter chara, Transform charaContainer, MeshRenderer filterBouboule, TextMeshProUGUI text, AudioSource source, AudioClip audioClip)
    {
        associatedCharacter = chara;
        _charaContainer = charaContainer;
        _meshFilterBouboule = filterBouboule;
        _text = text;
        _source = source;
        _defaultClip = audioClip;
        Init();
    }
    // Start is called before the first frame update
    private void Init()
    {
        if(associatedCharacter)
            buttonIcon.sprite = associatedCharacter.iconSprite;
    }

    public void SetCharandBouboule()
    {
        for (int i = 0; i < _charaContainer.childCount; i++)
        {
            var child = _charaContainer.GetChild(i);
            Destroy(child.gameObject);
        }
        Instantiate(associatedCharacter.characterMesh,_charaContainer);
        _meshFilterBouboule.material = associatedCharacter.materialForKatamari;
        _text.text = associatedCharacter.charaName;
        _source.Stop();
        _source.clip = associatedCharacter.voiceAnouncement != null? associatedCharacter.voiceAnouncement: _defaultClip;
        _source.Play();
    }

    
}
