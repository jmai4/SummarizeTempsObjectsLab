﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            int SumOfTemps = 0;
            // add logic to calculate the average
            foreach (int temp in _temperatures)
            {

                SumOfTemps += temp;

            }
            return SumOfTemps/_temperatures.Count; // <-- Replace this with the actual average
        }

        public int TempsAboveThreshold(int threshold)
        {
            // add logic to calculate temps above the threshold
            return 0; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            // add logic to calculate and return temps below the threshold
            return 0; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            // add logic to calculate and return temps at the threshold
            return 0; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            return _temperatures.Count; // <-- Replace this with the number
        }
    }
}
