using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 moveAxis = new Vector3(1f, 0f, 0f);
    public float frequency = 2f;
    public float magnitude = 5f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.position = startPos + moveAxis * Mathf.Sin(Time.time * frequency) * magnitude;
    }
}
