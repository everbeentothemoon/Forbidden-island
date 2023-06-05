using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForbiddenIslandCards : MonoBehaviour
{
    public class FICards
    {
        public enum TrainType
        {
            None,
        }

        [SerializeField]
        private TrainType traintype;
        public TrainType treasure => traintype;
        [SerializeField]
        private string name;
        public string Name => name;
        public FICards (TrainType train)
        {
            traintype = treasure;
            name = traintype.ToString ();
        }
    }
}
