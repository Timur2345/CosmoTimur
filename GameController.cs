using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static float gameSpeed = 0f;

    [Range(0,5)]

    public float gameSpeedRegulator;
    public float speedRate = 0.5f;
    public float gameSpeesMax = 5f;

    void Update()
    {
        if (gameSpeedRegulator <= gameSpeesMax)
        {
            gameSpeedRegulator += speedRate * Time.deltaTime;
        }
        gameSpeed = gameSpeedRegulator;
    }
}
