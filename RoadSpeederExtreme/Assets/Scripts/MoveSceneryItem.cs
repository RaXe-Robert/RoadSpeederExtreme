﻿using UnityEngine;
using System.Collections;

public class MoveSceneryItem : MonoBehaviour
{

    [SerializeField]
    float playerSpeed;

    GameController GameControllerScript;


    // Use this for initialization
    void Start()
    {
        GameControllerScript = GameObject.Find("GameScripts").GetComponent<GameController>();
        playerSpeed = GameControllerScript.playerSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        playerSpeed = GameControllerScript.playerSpeed;

        if (this.tag == "Trees")
        {
            transform.Translate(0, 0, playerSpeed * 4 * Time.deltaTime);
        }

        if (this.tag == "Clouds")
        {
            transform.Translate(0.1f, 0, 0.05f);
            transform.Translate(0, 0, (playerSpeed / 5 * Time.deltaTime));
        }

        if (this.tag == "Cars")
        {
            transform.Translate(playerSpeed * 2 * Time.deltaTime - 120 * Time.deltaTime, 0, 0);
        }

        if (transform.position.z >= 5100)
            Destroy(this.gameObject);

    }
}
