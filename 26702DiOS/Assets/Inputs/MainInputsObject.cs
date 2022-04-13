using UnityEngine;

[CreateAssetMenu]
public class MainInputsObject : ScriptableObject
{
    public MainInputs mainInputs;
    
    void OnEnable()
    {
        mainInputs = new MainInputs();
        mainInputs.Enable();
    }
}
