using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabReader : MonoBehaviour
{
    public KatamariCharacter associatedCharacter;
    public Image buttonIcon;

    private Transform charaContainer;
    private MeshRenderer meshFilterBouboule;

    public void Associate(KatamariCharacter chara, Transform charaContainer, MeshRenderer filterBouboule)
    {
        associatedCharacter = chara;
        this.charaContainer = charaContainer;
        this.meshFilterBouboule = filterBouboule;
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
        var child = charaContainer.GetChild(0);
        Destroy(child.gameObject);
        Instantiate(associatedCharacter.characterMesh,charaContainer);
        meshFilterBouboule.material = associatedCharacter.materialForKatamari;
    }

    
}
