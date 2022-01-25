using UnityEngine;

[CreateAssetMenu]
public class WizardCharacter : CharacterBase
{
   public Color wizardHatColor = Color.blue;

   public override void Walk()
   {
      base.Walk();
      Debug.Log(skinColor);
   }
}
