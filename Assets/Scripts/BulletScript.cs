using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    private Transform target;

    public float speed = 50f;
    public float explosionRadius = 0f;
    private float damage;

	public void Seek(Transform _target, float _damage)
    {
        target = _target;
        damage = _damage;
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

        Vector2 lookdir = target.position - transform.position;
        float angle = Mathf.Atan2(lookdir.y, lookdir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    void HitTarget()
    {
        if(explosionRadius > 0f)
        {
            Explode();
        }
        else
        {
            Damage(target);
        }
        
        Destroy(gameObject);
    }

    void Damage(Transform enemy)
    {
        enemy.GetComponent<Minion>().health -= damage;
    }

    void Explode()
    {
        Collider2D[] hitObjects = Physics2D.OverlapCircleAll(transform.position, explosionRadius);
        foreach (Collider2D hitObject in hitObjects)
        {
            if(hitObject.tag == "Enemy")
            {
                Damage(hitObject.transform);
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }
}
