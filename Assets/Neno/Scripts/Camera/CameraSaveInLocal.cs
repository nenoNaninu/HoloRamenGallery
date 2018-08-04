using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HoloToolkit.Unity.InputModule;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.WSA.WebCam;

namespace Neno.Scripts
{
    //PhotoCapture、一回写真撮るごとにCreateしないといけないっぽいのでリアルタイムに画像投げるには不向きな気がする。
    public class CameraSaveInLocal : MonoBehaviour,IInputClickHandler
    {
        [SerializeField] private Text text;
        private PhotoCapture photoCapture;
        private CameraParameters cameraParameters;

        // Use this for initialization
        void Start()
        {
            InputManager.Instance.AddGlobalListener(gameObject);
            PhotoCapture.CreateAsync(false, (captureObj) =>
            {
                this.photoCapture = captureObj;
                Resolution resolution = PhotoCapture.SupportedResolutions.OrderByDescending((res => res.width * res.height)).First();
                cameraParameters = new CameraParameters
                {
                    cameraResolutionHeight = resolution.height,
                    cameraResolutionWidth = resolution.width,
                    hologramOpacity = 0f,
                    pixelFormat = CapturePixelFormat.BGRA32
                };
            });
        }
        
        // Update is called once per frame
        void Update()
        {

        }

        void TakePhoto()
        {
            this.photoCapture.StartPhotoModeAsync(this.cameraParameters,(result =>
            {
                if(result.success)
                {

                    string filename = string.Format(@"CapturedImage{0}_n.jpg", Time.time);

                    string filePath = System.IO.Path.Combine(Application.persistentDataPath, filename);
                    this.text.text = filePath;
                    this.photoCapture.TakePhotoAsync(filePath, PhotoCaptureFileOutputFormat.JPG, (captureResult =>
                    {

                    }));
                }
            } ));
        }

        public void OnInputClicked(InputClickedEventData eventData)
        {
            this.text.text = "clicked";
            TakePhoto();
        }
        
        void OnApplicationQuit()
        {
            this.photoCapture.Dispose();
            this.photoCapture = null;
        }
    }

}

