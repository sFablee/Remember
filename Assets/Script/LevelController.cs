using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [SerializeField] string _nextLevelName;

    Monster[] _monsters;

    void OnEnable()
    {
        _monsters = FindObjectsOfType<Monster>();   
    }
    // Update is called once per frame
    void Update()
    {
        if (MonstersAreAllDead())
            GoToNextLevel();
    }

    private void GoToNextLevel()
    {
        Debug.Log("Go to Level " + _nextLevelName);
        SceneManager.LoadScene(_nextLevelName);
    }

    private bool MonstersAreAllDead()
    {
        foreach (var monster_ko in _monsters)
        {
            if (monster_ko.gameObject.activeSelf)
                return false;
        }

        return true;
    }
}
