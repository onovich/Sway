using System.Collections;
using System.Collections.Generic;
using MortiseFrame.Abacus;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MortiseFrame.Sway.Sample {

    public class DragableElement : MonoBehaviour {

        public int index;
        public Vector3 Pos => transform.position;
        public FVector3 FPos => new FVector3(Pos.x, Pos.y, Pos.z);

    }

}