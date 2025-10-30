using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace StrandedScatterer
{
	[KSPAddon(KSPAddon.Startup.EveryScene, false)]
	public class StrandedScatterer: MonoBehaviour
	{
	    public Camera farCamera, scaledSpaceCamera, nearCamera;
	
	    void Init()
		{
			scaledSpaceCamera = Camera.allCameras.FirstOrDefault (_cam => _cam.name == "Camera ScaledSpace");
			farCamera = Camera.allCameras.FirstOrDefault (_cam => _cam.name == "Camera 01");
			nearCamera = Camera.allCameras.FirstOrDefault (_cam => _cam.name == "Camera 00");
	
	    	scaledSpaceCamera.gameObject.AddComponent<ParticleSystem>();
	      	farCamera.gameObject.AddComponent<ParticleSystem>();
	      	nearCamera.gameObject.AddComponent<ParticleSystem>();

			scaledSpaceCamera.gameObject.GetComponent<ParticleSystem>().Stop();
	      	farCamera.gameObject.GetComponent<ParticleSystem>().Stop();
	      	nearCamera.gameObject.GetComponent<ParticleSystem>().Stop();
	
	      	var camera1 = scaledSpaceCamera.gameObject.GetComponent<ParticleSystem>().main;
	      	var camera2 = farCamera.gameObject.GetComponent<ParticleSystem>().main;
	      	var camera3 = nearCamera.gameObject.GetComponent<ParticleSystem>().main;
	
	      	camera1.startLifetime = 10.0f;
			camera2.startLifetime = 10.0f;
			camera3.startLifetime = 10.0f;

			camera1.startSize = 10.0f;
			camera2.startSize = 10.0f;
			camera3.startSize = 10.0f;
	
	      	scaledSpaceCamera.gameObject.GetComponent<ParticleSystem>().Play();
	      	farCamera.gameObject.GetComponent<ParticleSystem>().Play();
	      	nearCamera.gameObject.GetComponent<ParticleSystem>().Play();
	    }
  	}
}
