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

    public void Associate(KatamariCharacter chara, Transform charaContainer, MeshRenderer filterBouboule, TextMeshProUGUI text, AudioSource source)
    {
        associatedCharacter = chara;
        _charaContainer = charaContainer;
        _meshFilterBouboule = filterBouboule;
        _text = text;
        _source = source;
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
        if(associatedCharacter.voiceAnouncement)
        {
            _source.Stop();
            _source.clip = associatedCharacter.voiceAnouncement;
            _source.Play();
        }
    }

    
}
