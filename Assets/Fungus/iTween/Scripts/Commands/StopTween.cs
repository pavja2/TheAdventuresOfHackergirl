/**
 * This code is part of the Fungus library (http://fungusgames.com) maintained by Chris Gregan (http://twitter.com/gofungus).
 * It is released for free under the MIT open source license (https://github.com/snozbot/fungus/blob/master/LICENSE)
 */

﻿using UnityEngine;
using UnityEngine.Serialization;
using System.Collections;

namespace Fungus
{
	[CommandInfo("iTween", 
	             "Stop Tween", 
	             "Stops an active iTween by name.")]
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	public class StopTween : Command
	{
		[Tooltip("Stop and destroy any Tweens in current scene with the supplied name")]
		public StringData _tweenName;

		public override void OnEnter()
		{
			iTween.StopByName(_tweenName.Value);
			Continue();
		}

		#region Backwards compatibility

		[HideInInspector] [FormerlySerializedAs("tweenName")] public string tweenNameOLD = "";

		protected virtual void OnEnable()
		{
			if (tweenNameOLD != "")
			{
				_tweenName.Value = tweenNameOLD;
				tweenNameOLD = "";
			}
		}

		#endregion
	}

}