﻿using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcObjectSpawnData : NMSTemplate // 0x378 bytes
    {
        /* 0x000 */ public int Type;
        public string[] TypeValues()
        {
            return new[] { "Instanced", "Single" };
        }
        [NMS(Size = 4, Ignore = true)]
        /* 0x004 */ public byte[] Padding4;

        /* 0x008 */ public GcResourceElement Resource;
        /* 0x2B0 */ public List<GcResourceElement> AltResources;

        /* 0x2C0 */ public GcTerrainTileType PlacementTileType;
        [NMS(Size = 4, Ignore = true)]
        /* 0x2C4 */ public byte[] Padding2C4;

        /* 0x2C8 */ public List<GcTerrainTileType> ExtraTileTypes;

        [NMS(Size = 0x10)]
        /* 0x2D8 */ public string Placement;
        /* 0x2E8 */ public GcSeed PlacementSeed;
        /* 0x2F8 */ public int PlacementPriority;
        public string[] PlacementPriorityValues()
        {
            return new[] { "Low", "Normal", "High" };
        }

        /* 0x2FC */ public float PlacementCoverage;
        /* 0x300 */ public float PlacementFlatDensity;
        /* 0x304 */ public float PlacementSlopeDensity;
        /* 0x308 */ public float PlacementSlopeMultiplier;

        /* 0x30C */ public int RestrictionsLargeObjectCoverage;
        public string[] RestrictionsLargeObjectCoverageValues()
        {
            return new[] { "DoNotPlace", "DoNotPlaceClose", "OnlyPlaceAround", "AlwaysPlace" };
        }
        /* 0x310 */ public int RestrictionsOverlapStyle;
        public string[] RestrictionsOverlapStyleValues()
        {
            return new[] { "None", "SameSeed", "All" };
        }
        /* 0x314 */ public float RestrictionsMinHeight;
        /* 0x318 */ public float RestrictionsMaxHeight;
        /* 0x31C */ public bool RestrictionsRelativeToSeaLevel;
        /* 0x320 */ public float RestrictionsMinAngle;
        /* 0x324 */ public float RestrictionsMaxAngle;

        /* 0x328 */ public int FadeMinRegionRadius; // might be float
        /* 0x32C */ public int FadeMaxRegionRadius; // might be float
        /* 0x330 */ public int FadeMaxImposterRadius; // might be float

        /* 0x334 */ public float FadeInStartDistance;
        /* 0x338 */ public float FadeInEndDistance;
        /* 0x33C */ public float FadeInOffsetDistance;
        /* 0x340 */ public float FadeOutStartDistance;
        /* 0x344 */ public float FadeOutEndDistance;
        /* 0x348 */ public float FadeOutOffsetDistance;

        /* 0x34C */ public bool MatchGroundColour;
        /* 0x350 */ public int GroundColourIndex;
        public string[] GroundColourIndexValues()
        {
            return new[] { "Auto", "Main", "Patch" };
        }

        /* 0x354 */ public bool SwapPrimaryForSecondaryColour;
        /* 0x355 */ public bool SwapPrimaryForRandomColour;

        /* 0x356 */ public bool PositioningAlignToNormal;
        /* 0x358 */ public float PositioningMinScale;
        /* 0x35C */ public float PositioningMaxScale;
        /* 0x360 */ public float PositioningMinScaleY;
        /* 0x364 */ public float PositioningMaxScaleY;
        /* 0x368 */ public float PositioningSlopeScaling;
        /* 0x36C */ public float PositioningPatchEdgeScaling;
        /* 0x370 */ public float PositioningMaxXZRotation;

        /* 0x374 */ public bool ObjectAutoCollision;
        /* 0x375 */ public bool ObjectCollideWithPlayer;
        /* 0x376 */ public bool CollideWithPlayerVehicle;
        /* 0x377 */ public bool DestroyedByPlayerVehicle;
        /* 0x378 */ public bool ObjectCreaturesCanEat;
        /* 0x37C */ public float ObjectShearWindStrength;
        [NMS(Size = 0x10)]
        /* 0x380 */ public string DestroyedByVehicleEffect;

        /* 0x390 */ public int RuntimeCacheCachedCollisionNodeCount; // might be float
        /* 0x394 */ public bool RuntimeCacheAllowLimiting;
    }
}
