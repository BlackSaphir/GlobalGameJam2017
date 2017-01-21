using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    private Transform target;

    public float speed = 50f;

	public void Seek(Transform _target)
    {
        target = _target;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector2 dir = target.position - transform.position;
        float distanceTraveled = speed * Time.deltaTime;

        if(dir.magnitude <= distanceTraveled)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceTraveled, Space.World);
	}

    void HitTarget()
    {
        Destroy(gameObject);
    }
}
