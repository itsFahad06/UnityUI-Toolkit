using System;
using UnityEngine;
using UnityEngine.UIElements;

public class ButtonClick : MonoBehaviour
{
    private Button _click;
    private Label _label;

    private void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        _click = root.Q<Button>("click");
        _label = root.Q<Label>("change");
        
        _click.RegisterCallback<ClickEvent>(OnButtonClicks);
    }

    private void OnButtonClicks(ClickEvent evt)
    {
        _label.text = "Video number 3";
    }
}
