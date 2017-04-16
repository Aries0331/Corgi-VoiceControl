using UnityEngine;
using System.Collections;
using SimpleJSON;

public partial class Wit3D : MonoBehaviour {

	void Handle(string textToParse) {

		print (textToParse);
		var N = JSON.Parse (textToParse);
		print ("SimpleJSON: " + N.ToString());

		string action = N["entities"]["action"][0]["value"].ToString();
		action = action.Replace ("\"", "");
		print ("---------" + action);
		print ("+++++++++" + N["entities"]["action"][0]["value"].ToString());

		//action = "run";
		// what function should I call?
		switch (action)
		{
		case "sit":
			anim.SetInteger ("animation", 3);
			print ("sit");
			break;
		case "run":
			anim.SetInteger ("animation", 5);
			print ("run");
			break;
		case "lay":
			anim.SetInteger ("animation", 1);
			print ("lay");
			break;
		case "stop":
			anim.SetInteger ("animation", 0);
			print ("idle");
			break;
		case "stand":
			anim.SetInteger ("animation", 0);
			print ("idle");
			break;		
		case "walk":
			anim.SetInteger ("animation", 6);
			print ("walk");
			break;
//		case "O":
//			anim.SetInteger ("animation", 0);
//			print ("idle");
//			break;
		default:
			print ("Sorry, didn't understand your intent.");
			break;
		}


	}
}
