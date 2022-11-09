using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using static UnityEngine.Rendering.DebugUI;

namespace LukaDimopoulos
{
    public class Aquarium : MonoBehaviour
    {
        [SerializeField] List<Fish> listOfFish = new List<Fish>();
        [SerializeField] private string[] species = { "Betta", "Piranha", "Koi", "Guppy", "Surgeon Fish", "Tuna", "Oarfish" };
        private Fish smallestLength;
        private float totalValue;
        public float length;

        [SerializeField] private GameObject fishPrefab;
        public Fish newFish;
        public int counter;

       

        private GameObject newFishStart;

        public void KeepFishButton()
        {
            listOfFish.Add(newFish);
            totalValue += newFish.dollarvalue;

            AddedFish();
            counter++;
            Debug.Log(counter);

            RoundCounter();
        }

        public void Start()
        {
            AddedFish();
        }

        public void AddedFish()
        {
            newFishStart = Instantiate(fishPrefab, transform);
            newFish = newFishStart.GetComponent<Fish>();
        }

        public void DeleteButton()
        {
            Destroy(newFish.gameObject);

            AddedFish();
            counter++;

            RoundCounter();
        }

        private void RoundCounter()
        {
            if (counter == 10)
            {
                SceneManager.LoadScene(2);
                Debug.Log("Game Over");
            }
        }
        void LengthOfSpecies()
        {
            for (int i = 0; i < species.Length; i++)
            {
                if (species[i] == "Betta" || species[i] == "Piranha")
                {
                    length += Random.Range(1f, 100f);
                }
                if (species[i] == "Koi" || species[i] == "Guppy")
                {
                    length += Random.Range(1f, 100f);
                }
                if (species[i] == "Surgeon Fish")
                {
                    length += Random.Range(1f, 100f);
                }
                if (species[i] == "Tuna")
                {
                    length += Random.Range(1f, 100f);
                }
                if (species[i] == "Oarfish")
                {
                    length += Random.Range(1f, 100f);
                }
            }
        }

        void ValueOfSpecies()
        {
            for (int i = 0; i < species.Length; i++)
            {
                if (species[i] == "Betta")
                {
                    totalValue += Random.Range(10, 100);
                }
                if (species[i] == "Piranha")
                {
                    totalValue += Random.Range(10, 300);
                }
                if (species[i] == "Koi")
                {
                    totalValue += Random.Range(500, 5000);
                }
                if (species[i] == "Guppy")
                {
                    totalValue += Random.Range(10, 1000);
                }
                if (species[i] == "Surgeon Fish")
                {
                    totalValue += Random.Range(10, 2000);
                }
                if (species[i] == "Tuna")
                {
                    totalValue += Random.Range(10, 500);
                }
                if (species[i] == "Oarfish")
                {
                    totalValue += Random.Range(10, 600);
                }

            }
        }
    }
}
