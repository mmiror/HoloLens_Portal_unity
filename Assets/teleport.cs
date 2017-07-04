using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HoloToolkit.Unity.InputModule
{
    public class teleport : MonoBehaviour, IInputClickHandler
    {

        public Collider me;
        // Use this for initialization
        void Start()
        {

        }
        public void OnInputClicked(InputClickedEventData eventData)
        {
            if (GazeManager.Instance.IsGazingAtObject)
            {
                Vector3 hit = GazeManager.Instance.HitPosition;
                me.transform.root.position = hit + new Vector3(0, 1.8f, 0);
                Debug.Log(hit);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}