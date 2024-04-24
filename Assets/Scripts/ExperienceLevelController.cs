using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public class ExperienceLevelController : MonoBehaviour
{
    public static ExperienceLevelController instance;

    private void Awake()
    {
        instance = this;
    }

    public int currentExperience;

    void Start()
    {

    }

    void Update()
    {

    }

    public void GetExp(int amountToGet)
    {
        currentExperience += amountToGet;
    }
}
