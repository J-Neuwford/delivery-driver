using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    bool hasPackage;
    [SerializeField] Color32 hasPackageColour = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 hasNoPackageColour = new Color32(1, 1, 1, 1);

    [SerializeField] float destroyDelay = 0.2f;

    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColour;
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package Delivered");
            hasPackage = false;
            spriteRenderer.color = hasNoPackageColour;  
        }
    }
}

