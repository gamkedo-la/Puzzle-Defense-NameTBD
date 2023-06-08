using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript GameManagerScriptInstance;

    public float floatDistanceForTriggeringBaseInvasion = 1.0f;

    public float wallPositionMovementFloat = 0.5f;

    public float cowmationSpawnInterval = 10.0f;

    public void Awake()
    {
        if (GameManagerScriptInstance == null)
        {
            GameManagerScriptInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        Debug.Log("GameManagerScriptInstance: " + GameManagerScriptInstance);
    }
}