using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    public Animator animator_;
    private void OnMouseDown()
    {
        animator_.SetTrigger("Start");
    }
}
