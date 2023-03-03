using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Playables;
using UnityEngine.UI;
using Klak.VJUI;

sealed class CS_all_MidiInputSlider : MonoBehaviour
{
    [SerializeField] Slider _slider;
    //[SerializeField] Knob _knob;
    //[SerializeField] Klak.VJUI.Button _button;

    [SerializeField] InputAction _action  =null;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    void OnEnable()
    {
        _action.performed += OnPerformed;
        _action.Enable();
    }

    void OnDesable()
    {
        _action.performed -= OnPerformed;
        _action.Disable();
    }

    void OnPerformed(InputAction.CallbackContext ctx)
        => _slider.value = ctx.ReadValue<float>();
        //=> _knob.value = ctx.ReadValue<float>();
        //=> _button.value = ctx.ReadValue<float>();
}
