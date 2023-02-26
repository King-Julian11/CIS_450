using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public float spawnDistance;
    private Transform playerOrCameraTransform;

    public CarFactory carFactory;
    public bool isFord;

    public List<GameObject> fords;
    public List<GameObject> toyotas;

    // Start is called before the first frame update
    void Start()
    {
        spawnDistance = 20f;
        playerOrCameraTransform = Camera.main.transform;

        carFactory = new FordCarFactory();
        isFord = true;
    }

    public GameObject SpawnCar(string brand)
    {
        GameObject car = null;

        car = carFactory.CreateCarPrefab(brand);

        float xRand = Random.Range(-10, 10);
        float zRand = Random.Range(-10, 10);
        Vector3 spawnPos = playerOrCameraTransform.position +
                           playerOrCameraTransform.forward * spawnDistance +
                           new Vector3(xRand, 0, zRand);

        GameObject carInstance = Instantiate(car, spawnPos, playerOrCameraTransform.rotation);

        carFactory.AddCarBrand(carInstance, brand);

        return carInstance;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (isFord)
            {
                carFactory = new ToyotaCarFactory();
                isFord = false;
            }
            else
            {
                carFactory = new FordCarFactory();
                isFord = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (isFord)
            {
                fords.Add(SpawnCar("Bronco"));
            }
            else
            {
                toyotas.Add(SpawnCar("Prius"));
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (isFord)
            {
                fords.Add(SpawnCar("Mustang"));
            }
            else
            {
                toyotas.Add(SpawnCar("Mirai"));
            }
        }
    }
}
