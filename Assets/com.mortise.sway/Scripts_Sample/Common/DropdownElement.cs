using System.Collections;
using System.Collections.Generic;
using MortiseFrame.Abacus;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MortiseFrame.Sway.Sample {

    public class DropdownElement : MonoBehaviour, IPointerClickHandler {
        public Dropdown[] otherDropDown;
        public void OnPointerClick(PointerEventData eventData) {
            foreach (var item in otherDropDown) {
                item.Hide();
            }
        }
    }

}