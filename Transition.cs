using UnityEngine;
using UnityEngine.UIElements;

namespace Script
{
    public class Transition : MonoBehaviour
    {
        private Button _btn;
        private Button _ct;
        private VisualElement _vs;
        private VisualElement _tp2;

        private void Start()
        {
            var root = GetComponent<UIDocument>().rootVisualElement;

            _btn = root.Q<Button>("btn");
            _ct = root.Q<Button>("ct");
            _vs = root.Q<VisualElement>("transitionpart1");
            _tp2 = root.Q<VisualElement>("tp2");
        
            _btn.RegisterCallback<ClickEvent>(OnBtn);
            _ct.RegisterCallback<ClickEvent>(OnctBtn);
        }

        private void OnBtn(ClickEvent evt)
        {
            _vs.AddToClassList("transitionnext");
            _tp2.AddToClassList("tp2extra");
        }
        
        private void OnctBtn(ClickEvent evt)
        {
            _vs.RemoveFromClassList("transitionnext");
            _tp2.RemoveFromClassList("tp2extra");
        }
    }
}
