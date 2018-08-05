using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

namespace Neno.Scripts
{
    public class PanelClose : MonoBehaviour,IInputClickHandler
    {
        public void OnInputClicked(InputClickedEventData eventData)
        {
            Destroy(gameObject.transform.parent.gameObject);
        }

        // Use this for initialization
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

