using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.WSA.Input;

namespace Neno.Scripts
{
    public class AirTapMoniter : MonoBehaviour, IInputClickHandler
    {

        [SerializeField] private Material raycastMaterial;
        [SerializeField] private Text uiText;

        GestureRecognizer gestureRecognizer = new GestureRecognizer();

        // Use this for initialization
        void Start()
        {
            InputManager.Instance.AddGlobalListener(gameObject);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnInputClicked(InputClickedEventData eventData)
        {
            //AirTap検出時の処理を記述
            uiText.text = "clicked";
            RaycastHit raycastHit;
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            
            if (Physics.Raycast(ray, out raycastHit))
            {
                raycastHit.collider.gameObject.GetComponent<Renderer>().material = raycastMaterial;
            }
        }
    }
}

