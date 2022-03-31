using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class FlockAgent : MonoBehaviour
{
    public int health = 25, damage = 5;
    public float shootCooldown = 1f;
    float startShootCooldown;

    public ParticleSystem explosion, blaster1, blaster2;

    GameObject closest;
    GameObject[] agents;

    Flock agentFlock;

    public Flock AgentFlock { get { return agentFlock; } }

    Collider agentCollider;

    public Collider AgentCollider { get { return agentCollider; } }

    void Start()
    {
        agentCollider = GetComponent<Collider>();
        startShootCooldown = shootCooldown;
    }

    void Update()
    {
        FindEnemy();

        if(agentFlock.active)
        {

            //Shoot(damage);
        }

        if (!agentFlock.active)
        {
            transform.position += transform.forward * Time.deltaTime * 50f;

        }

        if (health <= 0)
            Die();
    }

    public void Initialise(Flock flock)
    {
        agentFlock = flock;
    }

    public void Move(Vector3 velocity)
    {
        transform.forward = velocity;
        transform.position += velocity * Time.deltaTime;
    }

    public GameObject FindEnemy()
    {
        if (CompareTag("R"))
            agents = GameObject.FindGameObjectsWithTag("NE");

        if (CompareTag("NE"))
            agents = GameObject.FindGameObjectsWithTag("R");

        closest = null;

        float distance = Mathf.Infinity;

        Vector3 pos = transform.position;

        foreach (GameObject go in agents)
        {
            Vector3 diff = go.transform.position - pos;
            float currDistance = diff.sqrMagnitude;

            if(currDistance < distance)
            {
                closest = go;
                distance = currDistance;
            }
        }

        return closest;
    }

    public void Shoot(int dmg)
    {
        FlockAgent fa = closest.GetComponent<FlockAgent>();

        shootCooldown -= Time.deltaTime;

        if(shootCooldown <= 0f)
        {
            blaster1.Play();
            blaster2.Play();
            fa.health -= dmg;
            shootCooldown = startShootCooldown;
        }
    }

    void Die()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
