using UnityEngine;
using UnityEngine.UI;

public class InventoryLayoutBehaviour : MonoBehaviour
{
    [HideInInspector] public Image image;
    [HideInInspector] public Text label, buttonLabel;
    [HideInInspector] public Button button;

    private void Awake()
    {
        var images = GetComponentsInChildren<Image>();
        image = images[1];
        label = GetComponentInChildren<Text>();
        button = GetComponentInChildren<Button>();
        buttonLabel = button.GetComponentInChildren<Text>();
    }
}
