using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]


public class CS_toggleColor : MonoBehaviour
{ 

    [SerializeField] private Color onColor;
    [SerializeField] private Color offColor;

    private Toggle toggle;

    void Start()
    {
        toggle = GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(OnToggleValueChanged);
    }


    private void OnToggleValueChanged(bool isOn)
    {
        if (isOn)
        {
            //colors�͍\���̂̂��߁A�l�^�ł���normalColor�𒼐ڕς��邱�Ƃ͂ł��Ȃ��̂ň�U�ʕϐ��Ɋm�F
            var newColors = toggle.colors;
            newColors.normalColor = new Color(onColor.r, onColor.g, onColor.b, onColor.a);
            newColors.highlightedColor = new Color(onColor.r, onColor.g, onColor.b, onColor.a);
            //newColors.selectedColor = new Color(onColor.r, onColor.g, onColor.b, onColor.a);
            toggle.colors = newColors;

        }
        else
        {
            var newColors = toggle.colors;
            newColors.normalColor = new Color(offColor.r, offColor.g, offColor.b, offColor.a);
            newColors.highlightedColor = new Color(offColor.r, offColor.g, offColor.b, offColor.a);
            //newColors.selectedColor = new Color(offColor.r, offColor.g, offColor.b, offColor.a);
            toggle.colors = newColors;
        }
    }
}