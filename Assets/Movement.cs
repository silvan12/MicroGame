using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class Movement : MonoBehaviour
{
    public float moveSpeed;
    private void Update()
    {
        // Looks at X movement mouse
        
        // transform.position = mousePos;
        Vector2 mousePos = Input.mousePosition;
        transform.position = Vector2.MoveTowards(gameObject.transform.position, mousePos, moveSpeed * Time.deltaTime);


        // Vector2 mousePos = new Vector2(xPos, 0);
        // transform.right = Vector2.MoveTowards(gameObject.transform.position, )
    }
}
