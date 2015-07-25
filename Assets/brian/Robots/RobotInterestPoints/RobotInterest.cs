﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RobotInterest : MonoBehaviour {

	public static List<RobotInterest> interestPoints = new List<RobotInterest>();

	public string Type = "";

	protected List<Action> possibleActions = new List<Action>();

	// Use this for initialization
	void Start () {
		//print ("called start on: " + this.GetType());
		if (isVisible()) {

			interestPoints.Add (this);
		}
	}

	virtual protected bool isVisible() {
		return true;
	}

	protected List<Action> getAvailableActions() {
		return possibleActions;
	}
}