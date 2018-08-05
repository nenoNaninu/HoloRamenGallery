using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HoloToolkit.Unity.InputModule;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

namespace Neno.Scripts
{
    /// <summary>
    /// パネル一枚一枚にアタッチするスクリプト
    /// </summary>
    public class FirstImagePanel : MonoBehaviour, IInputClickHandler, IFocusable
    {

        /// <summary>
        /// この配列にあらかじめ変換しておいた画像のマテリアルを入れておいて、パネルが選ばれたら大きいほうのパネルに一気に書き換える。
        /// </summary>
        [SerializeField] private Material[] translateMaterials;
        [SerializeField] private SecondSelectParent secondSelectParent;
        [SerializeField] private GameObject photoPanel2Create;
        [SerializeField] private FirstImagePanelParent firstImagePanelParent;

        public int TapCount { get; set; } = 0;

        public void OnFocusEnter()
        {
            //大きくする

        }

        public void OnFocusExit()
        {
            //元の大きさに戻す。
        }

        public void OnInputClicked(InputClickedEventData eventData)
        {
            if (this.TapCount == 0)
            {
                this.firstImagePanelParent.ClearTapCount();
                this.TapCount = 1;

                //secondPanelsを書き換える。もし表示されていなかったら表示する。
                if (!secondSelectParent.gameObject.activeSelf)
                {
                    secondSelectParent.gameObject.SetActive(true);
                }

                Renderer[] renderers = this.secondSelectParent.GerRenderers;

                for (int i = 0, n = renderers.Length; i < n; i++)
                {
                    renderers[i].material = this.translateMaterials[i];
                }
            }
            else
            {
                //今のマテリアルのインスタンスを生成する。
                TapCount = 0;
                GameObject photoPanelObj = Instantiate(this.photoPanel2Create,
                    Camera.main.transform.position + Camera.main.transform.forward + Camera.main.transform.up *0.3f,
                    Quaternion.LookRotation(-Camera.main.transform.forward));

                photoPanelObj.GetComponent<Renderer>().material = gameObject.GetComponent<Renderer>().material;
            }
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

