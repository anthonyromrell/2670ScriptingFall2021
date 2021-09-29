using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class SimpleTextBehaviour : MonoBehaviour
{
    private Text Label;
    void Awake()
    {
        Label = GetComponent<Text>();
    }

    public void UpdateTextValue(IntData obj)
    {
        Label.text = obj.value.ToString();
    }
}
