string[] componentSubtypeStrings = { "BulletproofGlass", "Canvas", "Computer", "Construction", "Detector",
                                             "Display", "Explosives", "Girder", " GravityGenerator", "InteriorPlate",
                                             "LargeTube", "Medical", "MetalGrid", "Motor", "PowerCell",
                                             "RadioCommunication", "Reactor", "SmallTube", "SolarCell", "SteelPlate",
                                             "Superconductor", "Thrust" };

double[] componentThresholds = {10, 10, 100, 200, 10,
                                  75, 10, 10, 0, 100,
                                  50, 0, 100, 100, 80,
                                  0, 0, 200, 0, 2000,
                                  0, 0};

foreach (string subtype in componentSubtypeStrings)
	{                   
		itemBlueprints.Add(MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/" + subtype));
	}
	
for (int i = 0; i < itemTypes.Count; i++)
	{
		if ((double)largeCargoInventory.GetItemAmount(itemTypes[i]) < componentThresholds[i])
		{
			assembler.AddQueueItem(itemBlueprints[i], (double)10);
		}
	}