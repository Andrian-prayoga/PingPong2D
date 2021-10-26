using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
	public float kecepatan;
	public string axisx;
	public string axisy;
	public float batasAtas;
	public float batasBawah;
	public float batasKanan;
	public float batasKiri;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		float gerakx = Input.GetAxis(axisx) * kecepatan * Time.deltaTime;
        float geraky = Input.GetAxis(axisy) * kecepatan * Time.deltaTime;
		
		float nextPosx = transform.position.x + gerakx;
		if (nextPosx > batasKanan)
		{
			gerakx = 0;
		}
		if (nextPosx < batasKiri)
		{
			gerakx = 0;
		}
		
		float nextPosy = transform.position.y + geraky;
		if (nextPosy > batasAtas)
		{
			geraky = 0;
		}
		if (nextPosy < batasBawah)
		{
			geraky = 0;
		}
		transform.Translate(gerakx, geraky, 0);
    }
}
