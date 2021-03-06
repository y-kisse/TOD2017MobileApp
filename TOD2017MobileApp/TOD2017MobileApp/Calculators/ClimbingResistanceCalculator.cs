﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOD2017MobileApp.Calculators.Components;

namespace TOD2017MobileApp.Calculators
{
    public static class ClimbingResistanceCalculator
    {
        //登坂抵抗力
        public static double CalcForce(double vehicleMass, double theta)
        {
            return vehicleMass * Math.Sin(theta) * Constants.GravityResistanceCoefficient;
        }

        //登坂抵抗による損失エネルギー, kWh/s
        public static double CalcPower(double vehicleMass, double theta, double vehicleSpeed)
        {
            return CalcForce(vehicleMass, theta) * vehicleSpeed / 3600 / 1000;
        }

		public static double CalcPowerPreVer(double carWeight, double altitudeDiff)
		{
			return carWeight * 9.8 * altitudeDiff * 0.278 * 0.000001;
		}
    }
}
