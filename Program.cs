﻿// See https://aka.ms/new-console-template for more information
using NewHomeWork;

Console.WriteLine("Clinika");

var patient1 = new Patient("Грачев Владимир");
var patient2 = new Patient("Селезнева Елена");
var patient3 = new Patient("Ковалев Эдуард");

patient1.AppointTreatmentPlan(1);
patient2.AppointTreatmentPlan(1);
patient3.AppointTreatmentPlan(1);

