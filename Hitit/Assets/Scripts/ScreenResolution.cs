﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenResolution : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.SetResolution ((int)Screen.width, (int)Screen.height, true);
	}
}
	

