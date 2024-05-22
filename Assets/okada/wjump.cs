using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wjump : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private BoxCollider2D boxCollider;
   // Start is called before the first frame update
   void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<PlayerMove>().GetItem();
        StartCoroutine(GottenItem());  
    }
    private IEnumerator GottenItem()
    {
        spriteRenderer.enabled = false;
        boxCollider.enabled = false;
        yield return new WaitForSeconds(3);
        spriteRenderer.enabled = true;
        boxCollider.enabled = true;
    }

}
