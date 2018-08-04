using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;
using UnityEngine.UI;

namespace Neno.Scripts
{
    public class AirTapOnObj : MonoBehaviour, IInputHandler, IInputClickHandler, IFocusable
    {
        [SerializeField] private Text uiForcusText;
        [SerializeField] private Text airtapText;
        [SerializeField] private GameObject ramenManager;


        public void OnFocusEnter()
        {
            uiForcusText.text = "OnFocusEnter";
        }

        public void OnFocusExit()
        {
            uiForcusText.text = "OnFocusExit";
        }

        public void OnInputClicked(InputClickedEventData eventData)
        {
            airtapText.text = string.Format("OnInputClicked Source: {0}  SourceId: {1} TapCount: {2}",
                eventData.InputSource, eventData.SourceId, eventData.TapCount);
            ramenManager.SetActive(true);
        }

        public void OnInputDown(InputEventData eventData)
        {
            airtapText.text = string.Format("OnInputDown Source: {0}  SourceId: {1}", eventData.InputSource,
                eventData.SourceId);
        }

        public void OnInputUp(InputEventData eventData)
        {
            airtapText.text = string.Format("OnInputUp\r\nSource: {0}  SourceId: {1}", eventData.InputSource,
                eventData.SourceId);
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


