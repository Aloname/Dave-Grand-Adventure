using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScoreScript : MonoBehaviour
{
    [SerializeField] private Image loadBar;

    [SerializeField] private BoxCollider2D midCollider;

    private float score = 0.07f;

    private void Start()
    {
        midCollider.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
           loadBar.fillAmount += score;
            Debug.Log("YAKIR");
        }
    }
}
