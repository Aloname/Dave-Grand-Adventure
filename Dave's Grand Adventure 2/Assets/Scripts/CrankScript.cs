using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrankScript : MonoBehaviour
{
    [SerializeField] private float force = 10f;

    [SerializeField] private GameObject crankBody;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private Image fillAnim;

    [SerializeField] private Image fillBar;

    [SerializeField] private Text[] dialogText;

    private int currText;
    void Start()
    {
        foreach(Text dialog in dialogText)
        {
            dialog.enabled = false;
        }

        currText = 0;

        gameObject.SetActive(false);
        crankBody.SetActive(false);
        fillBar.enabled = false;
        Invoke("GameStart", 7.3f);
    }

    void GameStart()
    {
         gameObject.SetActive(true);
        crankBody.SetActive(true);
        fillAnim.enabled = false;
        fillBar.enabled = true;
    }

    void Update()
   {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddRelativeForce(Vector2.left * force);
        }
    }
}
