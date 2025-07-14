using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float scrollSpeed; // Speed of the background scrolling

    public MeshRenderer meshRenderer; // Reference to the MeshRenderer component

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     meshRenderer.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, 0);
    }
}
