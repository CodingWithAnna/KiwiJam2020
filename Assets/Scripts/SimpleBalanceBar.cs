﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleBalanceBar : MonoBehaviour
{
   public Slider balanceBar;
   public playerBalance playerBalance;

void Start() {
    balanceBar.minValue = playerBalance.maxLeftLean;
    balanceBar.maxValue = playerBalance.maxRightLean;    
}

void Update(){
    balanceBar.value = playerBalance.currentBalance;
}

}

