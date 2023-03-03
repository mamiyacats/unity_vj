using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CS_2ddBankToPriset : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;

    private Vector3 prevPos;
    private Vector2 rootPos;
    private CanvasGroup canvasGroup;

    
    private void Awake()
    {
        //rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Use this for initialization
    void Start()
    {
        rootPos = new Vector3(Screen.width/2, Screen.height/2, 0f); 
    }

    
    public void OnBeginDrag(PointerEventData eventData)
    {
        prevPos = transform.localPosition;
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.localPosition = eventData.position -rootPos;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.localPosition = prevPos;
        canvasGroup.alpha = 1.0f;
        canvasGroup.blocksRaycasts = true;


    }



 

    // Update is called once per frame
    void Update()
    {

    }
}