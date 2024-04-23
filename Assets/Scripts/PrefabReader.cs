using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrefabReader : MonoBehaviour
{
    public KatamariCharacter associatedCharacter;
    public Image buttonIcon;
    public TextMeshProUGUI text;

    private Transform charaContainer;
    private MeshRenderer meshFilterBouboule;


    public void Associate(KatamariCharacter chara, Transform charaContainer, MeshRenderer filterBouboule, TextMeshProUGUI text)
    {
        associatedCharacter = chara;
        this.charaContainer = charaContainer;
        this.meshFilterBouboule = filterBouboule;
        this.text = text;
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
        for (int i = 0; i < charaContainer.childCount; i++)
        {
            var child = charaContainer.GetChild(i);
            Destroy(child.gameObject);
        }
        Instantiate(associatedCharacter.characterMesh,charaContainer);
        meshFilterBouboule.material = associatedCharacter.materialForKatamari;
        text.text = associatedCharacter.charaName;
    }

    
}
