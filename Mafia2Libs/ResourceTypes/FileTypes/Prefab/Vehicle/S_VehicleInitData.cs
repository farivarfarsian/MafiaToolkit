﻿using BitStreams;
using ResourceTypes.Prefab.CrashObject;

namespace ResourceTypes.Prefab.Vehicle
{
    public class S_VehicleInitData : S_DeformationInitData
    {
        public S_OtherInitData OtherInitData { get; set; }
        public S_AxleWheelInit WheelAxle { get; set; }
        public S_ShaderEffectInit ShaderEffects { get; set; }

        public override void Load(BitStream MemStream)
        {
            base.Load(MemStream);

            OtherInitData = new S_OtherInitData();
            OtherInitData.Load(MemStream);

            WheelAxle = new S_AxleWheelInit();
            WheelAxle.Load(MemStream);

            ShaderEffects = new S_ShaderEffectInit();
            ShaderEffects.Load(MemStream);
        }
    }
}
