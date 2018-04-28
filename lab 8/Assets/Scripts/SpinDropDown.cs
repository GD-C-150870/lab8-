using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinDropDown : MonoBehaviour {

    // define the possible states through an enumeration
    public enum spindirection { None, left, right, up, down, forward, backward };

    // store the state
    public spindirection SpinDirection;

    public float spinSpeed = 180.0f;

    // Update is called once per frame
    void Update()
    {
        switch (SpinDirection)
        {
            case spindirection.up:
                // rotate around the up axix of the gameObject
                gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
                break;

            case spindirection.down:
                // rotate around the up axix of the gameObject
                gameObject.transform.Rotate(Vector3.down * spinSpeed * Time.deltaTime);
                break;

            case spindirection.right:
                gameObject.transform.Rotate(Vector3.right * spinSpeed * Time.deltaTime);
                break;

            case spindirection.left:
                gameObject.transform.Rotate(Vector3.left * spinSpeed * Time.deltaTime);
                break;

            case spindirection.forward:
                // rotate around the up axix of the gameObject
                gameObject.transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
                break;

            case spindirection.backward:
                // rotate around the up axix of the gameObject
                gameObject.transform.Rotate(Vector3.back * spinSpeed * Time.deltaTime);
                break;
        }
    }

}
