using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //configuration parameters
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float screenWidthInUnits = 16f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float posX = Mathf.Clamp(Input.mousePosition.x / Screen.width * screenWidthInUnits,
                                 minX,
                                 maxX);
        Vector2 paddlePos = new Vector2(posX, transform.position.y);

        transform.position = paddlePos;
    }
}
