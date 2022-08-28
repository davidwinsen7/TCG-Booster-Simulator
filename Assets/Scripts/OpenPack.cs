using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPack : MonoBehaviour
{
    Material material;

    bool isAppearing = true;
    float fade = 0f;

    public GameObject cardPrefab;
    public Transform[] spawnPosition;

    private void Start()
    {
        material = GetComponent<SpriteRenderer>().material;   
    }

    private void Update()
    {
        if(isAppearing && fade < 1f)
        {
            fade += Time.deltaTime;
        }
        else if (!isAppearing && fade > 0f)
        {
            fade -= Time.deltaTime;
        }
        else if(!isAppearing && fade <= 0f)
        {
            Destroy(this.transform.parent.gameObject);
        }
        material.SetFloat("_Fade", fade);

        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            for(int i = 0; i < spawnPosition.Length; i++)
            {
                Instantiate(cardPrefab, spawnPosition[i].position, Quaternion.identity);
            }
            isAppearing = false;
        }
    }
}
