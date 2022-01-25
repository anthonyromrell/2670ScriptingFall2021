using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInstancer : MonoBehaviour
{

    private WizardCharacter wizCinfig;
    public WizardCharacter wizSetUpObj;

    public ColorList colorListObj;
    // Start is called before the first frame update
    void Start()
    {
        wizCinfig = ScriptableObject.CreateInstance<WizardCharacter>();
        wizCinfig.skinColor = wizSetUpObj.skinColor;
        var num = Random.Range(0, colorListObj.colors.Count-1);
        wizCinfig.Walk();
        print(wizCinfig.wizardHatColor);
    }

    
}
