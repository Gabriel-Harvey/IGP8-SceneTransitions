﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class handleButton : MonoBehaviour
{
    public InputField thetextField;


  public void buttonBehavior()
  {
        //string userID = thetextField.text.ToString();
        //PlayerPrefs.SetString("Name", userID);
        SceneManager.LoadScene("SampleScene");
  }

}
