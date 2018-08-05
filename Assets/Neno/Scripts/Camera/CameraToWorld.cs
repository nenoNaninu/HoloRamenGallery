using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.SpatialMapping;
using UnityEngine;
using UnityEngine.XR.WSA.WebCam;

public class CameraToWorld : MonoBehaviour {

	//// Use this for initialization
	//void Start () {
		
	//}
	
	//// Update is called once per frame
	//void Update () {
		
	//}

 //   void OnPhotoCaptured(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame)
 //   {
 //       Matrix4x4 cameraToWorldMatrix;
 //       photoCaptureFrame.TryGetCameraToWorldMatrix(out cameraToWorldMatrix);
 //       Matrix4x4 projectionMatrix;
 //       photoCaptureFrame.TryGetProjectionMatrix(out projectionMatrix);


 //       var imagePosZeroToOne = new Vector2(pixelPos.x / imageWidth, 1 - (pixelPos.y / imageHeight));
 //       var imagePosProjected = (imagePosZeroToOne * 2) - new Vector2(1, 1);    // -1 to 1 space

 //       var cameraSpacePos = UnProjectVector(projectionMatrix, new Vector3(imagePosProjected.x, imagePosProjected.y, 1));
 //       var worldSpaceCameraPos = cameraToWorldMatrix.MultiplyPoint(Vector3.zero);     // camera location in world space
 //       var worldSpaceBoxPos = cameraToWorldMatrix.MultiplyPoint(cameraSpacePos);   // ray point in world space

 //       RaycastHit hit;
 //       bool hitToMap = Physics.Raycast(worldSpaceCameraPos, worldSpaceBoxPos - worldSpaceCameraPos, out hit, 20, SpatialMappingManager.Instance.LayerMask);
 //   }

 //   public static Vector3 UnProjectVector(Matrix4x4 proj, Vector3 to)
 //   {
 //       Vector3 from = new Vector3(0, 0, 0);
 //       var axsX = proj.GetRow(0);
 //       var axsY = proj.GetRow(1);
 //       var axsZ = proj.GetRow(2);
 //       from.z = to.z / axsZ.z;
 //       from.y = (to.y - (from.z * axsY.z)) / axsY.y;
 //       from.x = (to.x - (from.z * axsX.z)) / axsX.x;
 //       return from;
 //   }
}
