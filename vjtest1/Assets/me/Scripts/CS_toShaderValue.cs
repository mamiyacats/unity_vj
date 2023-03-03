using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Klak.VJUI;

public class CS_toShaderValue : MonoBehaviour
{
    public RawImage _toShader;
    public List<Slider> _sliders;
    public List<Knob> _knobs;
    public List<CS_isOn> _buttons;
    public List<CS_isOnInt> _toggles;

    private Material material;

    // Start is called before the first frame update
    void Start()
    {
        _toShader.material = _toShader.GetComponent<RawImage>().material;
    }

    // Update is called once per frame
    void Update()
    {
        _toShader.material.SetFloat("_Over", _sliders[0].value);

        _toShader.material.SetFloat("_ScrollX", _knobs[0].value);

        _toShader.material.SetInt("_Posterize", _buttons[0].isOn);

        _toShader.material.SetInt("_FlipX", _toggles[0].isOnInt);
    }
}
