using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

namespace Neno.Scripts
{
    public class SelectImgUI : MonoBehaviour, IInputClickHandler,IFocusable
    {
        public void OnFocusEnter()
        {
            //スケールを大きくして強調
        }

        public void OnFocusExit()
        {
            //もとのスケールに戻す
        }

        public void OnInputClicked(InputClickedEventData eventData)
        {
            //ここでUIをいい感じに起動させる。
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

