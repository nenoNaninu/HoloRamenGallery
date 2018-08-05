using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity.SpatialMapping;
using UnityEngine;

namespace Neno.Scripts
{
    public class TapToPlace : MonoBehaviour,IInputClickHandler
    {
        private bool isMove = false;

        void IInputClickHandler.OnInputClicked(InputClickedEventData eventData)
        {
            isMove = !isMove;
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (!isMove) { return;}

            Transform cameraTransform = Camera.main.transform;
            Vector3 norlaml;
            gameObject.transform.position = GetPlacementPosition(cameraTransform, out norlaml);
            gameObject.transform.rotation = Quaternion.LookRotation(norlaml);
        }

        Vector3 GetPlacementPosition(Transform cameraTransform, out Vector3 nolomalVector)
        {
            RaycastHit raycastHit;
            //壁にぶつかった場合には壁に沿った感じで表示する。
            if (Physics.Raycast(cameraTransform.position, cameraTransform.forward,out raycastHit,30,
                SpatialMappingManager.Instance.LayerMask))
            {
                nolomalVector = raycastHit.normal;
                return raycastHit.point;
            }
            else
            {
                //壁にrayが当たらなかったら頭からgaze方向に15mの位置において頭の方向に向かせる。
                nolomalVector = -cameraTransform.forward;
                return cameraTransform.position + cameraTransform.forward * 3;
            }
        }

        
    }
}
