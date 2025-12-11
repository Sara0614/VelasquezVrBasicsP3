using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class MagnifyFollowLens : MonoBehaviour
    {
        public Transform lensTransform;

        void LateUpdate()
        {
            transform.position = lensTransform.position;
            transform.rotation = lensTransform.rotation;
        }
    }


