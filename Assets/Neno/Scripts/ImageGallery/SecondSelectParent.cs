using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Neno.Scripts
{
    public class SecondSelectParent : MonoBehaviour
    {

        [SerializeField]
        private Renderer[] renderers;

        public Renderer[] GerRenderers
        {
            get { return this.renderers; }
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
