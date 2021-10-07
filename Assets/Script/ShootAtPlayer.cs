using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtPlayer : MonoBehaviour
{
    public float FiringDelay = 3.0f;
    public float playerHitChance = 0.25f;
    private bool isLoaded = false;
    private float loadingTime = 0.0f;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLoaded)
        {
            loadingTime += Time.deltaTime;
            if (loadingTime > FiringDelay)
            {
                isLoaded = true;
                loadingTime = 0.0f;
            }
        }
        else if (isLoaded)
        {
            Debug.Log("Fired at Player");
            isLoaded = false;
            if (Random.value < playerHitChance)
            {
                Debug.Log("Player was Hit");
            }
            else
            {
                Debug.Log("Player was not Hit!");
            }
        }
    }
}
