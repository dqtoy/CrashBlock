﻿using UnityEngine;
using System.Collections;

namespace STB.ADAOPS
{
	///////////////////////////////////////////////////////////////////////////////////////////////////////
	/// <summary>
	/// Class: BloodyObject
	/// # To create a bloody dirty object
	/// </summary>
	///////////////////////////////////////////////////////////////////////////////////////////////////////
	public class BloodyObject : DirtyObject
	{
		///////////////////////////////////////////////////////////////////////////////////////////////////////
		/// <summary>
		/// Start
		/// # Start the class and set some values
		/// </summary>
		///////////////////////////////////////////////////////////////////////////////////////////////////////
		void Start ()
		{
			continuousMode = true;
			destroyTime = 20;
			scaleMultiplierRange = new Vector2 (2, 4);
			rotationRange = new Vector2 (0, 360);
		}
	}
}