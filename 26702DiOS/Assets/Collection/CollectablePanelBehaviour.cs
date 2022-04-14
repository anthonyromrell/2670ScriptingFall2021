using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CollectablePanelBehaviour : MonoBehaviour
{
    private Image image;
    private Text label, buttonLabel;
    private Button button;
    [HideInInspector] public Collectable collectableData;
    [HideInInspector] public IntData cash;
    private UnityAction collectAction;
    public GameAction checkCollectionAction;
    private void Awake()
    {
        var images = GetComponentsInChildren<Image>();
        image = images[1];
        label = GetComponentInChildren<Text>();
        button = GetComponentInChildren<Button>();
        buttonLabel = button.GetComponentInChildren<Text>();
        collectAction += CollectAction;
        checkCollectionAction.unityAction += CheckButton;
        button.onClick.AddListener(collectAction);
    }

    private void CheckButton()
    {
        button.gameObject.SetActive(true);
        button.interactable = CheckPrice();
        button.gameObject.SetActive(!collectableData.collected);
    }

    private void CollectAction()
    {
        collectableData.collected = true;
        cash.value -= collectableData.price;
        checkCollectionAction.unityAction.Invoke();
    }

    private void Start()
    {
        ConfigPanel();
    }

    private void ConfigPanel ()
    {
        image.sprite = collectableData.art;
        label.text = collectableData.name;
        buttonLabel.text = "Buy $" + collectableData.price;
        CheckButton();
    }

    
    
    private bool CheckPrice()
    {
        return cash.value >= collectableData.price;
    }
}
