﻿using VRage.Game.Components;
using System.Collections.Generic;
using Sandbox.Game.Entities;
using System.Linq;

namespace OreDetectorReforged.Detector
{
    class VoxelMapComponent : MyComponentBase
    {
        public readonly IDetectorPage[] data;

        public VoxelMapComponent(MyVoxelBase vb)
        {
            vb.Components.Add(this);
            var planet = vb as MyPlanet;
            if (planet == null)
                data = new IDetectorPage[] { new DetectorPageNotPlanet(vb) };
            else
                data = Enumerable.Range(0, 6).Select(f => new DetectorPagePlanet(planet, f)).ToArray();
        }
    }
}
