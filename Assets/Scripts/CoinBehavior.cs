using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    public AudioSource coinSound;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D whatIHit)
    {
        if (whatIHit.tag == "Player")
        {
            
            GameObject.Find("GameManager").GetComponent<GameManager>().EarnScore(1);
            this.transform.position = new Vector3(20f, transform.position.y, 0f);
            coinSound.Play();
            Destroy(this.gameObject, .5f);
        }

    }
}