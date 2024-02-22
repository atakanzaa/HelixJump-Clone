using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputController : MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IBeginDragHandler,IDragHandler
{

    [SerializeField] private Transform main;
    [SerializeField] private float speed;

    private float startPoint;
    public void OnPointerDown(PointerEventData eventData) // ekrana tikladigim vakit calisacak fonksiyon
    {

    }

    public void OnPointerUp(PointerEventData eventData)// elimi kaldirdigim an calisacak fonksiyon
    {

    }
    public void OnBeginDrag(PointerEventData eventData) //suruklemeye basladigim an calisacak fonksiyon
    {
        startPoint = eventData.position.x;
    }
    public void OnDrag(PointerEventData eventData) // surukledigim zamanlarda calisacak fonksiyon
    {
        var rotation = main.rotation;
        var current = rotation.eulerAngles.y;
        current += eventData.delta.x * speed;
        rotation.eulerAngles = new Vector3(0, current, 0);

        main.rotation = rotation;
    }
}
