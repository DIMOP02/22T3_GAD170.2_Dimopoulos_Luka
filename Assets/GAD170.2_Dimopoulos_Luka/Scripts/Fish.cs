using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

namespace LukaDimopoulos
{
    enum Species { bettaFish, piranhaFish, koiFish, guppyFish, surgeonFish, tunaFish, oarFish }
    public class Fish : MonoBehaviour
    {
        public string species;
        public float length = 0f;
        public int dollarvalue;

        [SerializeField] private string[] speciesArray = new string[7]; //{ "Betta", "Piranha", "koi", "Guppy", "SurgeonFish", "Tuna", "Oarfish" };

        public Fish(string newSpecies, int newDollarValue, float newLength)
        {
            species = newSpecies;
            length = newLength;
            dollarvalue = newDollarValue;
        }
        
        // Start is called before the first frame update
        void Start()
        {
            Stats();
        }

        public void Stats()
        {
            string randomSpecies = speciesArray[Random.Range(0, speciesArray.Length)];

            Debug.Log(randomSpecies);

            species = randomSpecies;

            length += Random.Range(1f, 100f);

            dollarvalue += Random.Range(10, 100);
        }
    }
}

