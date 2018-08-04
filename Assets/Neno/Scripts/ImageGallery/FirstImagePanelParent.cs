using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Neno.Scripts
{
    public class FirstImagePanelParent : MonoBehaviour
    {
        [SerializeField] private FirstImagePanel[] firstImagePanels;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public void ClearTapCount()
        {
            for (int i = 0,n = firstImagePanels.Length; i < n; i++)
            {
                this.firstImagePanels[i].TapCount = 0;
            }
        }
    }
}

