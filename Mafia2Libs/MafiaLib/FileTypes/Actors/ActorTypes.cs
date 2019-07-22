﻿using SharpDX;
using System;
using System.ComponentModel;
using System.IO;
using Utils.Extensions;
using Utils.SharpDXExtensions;
using Utils.StringHelpers;
using Utils.Types;

namespace ResourceTypes.Actors
{
    public interface IActorExtraDataInterface
    {
        void ReadFromFile(MemoryStream stream, bool isBigEndian);
        void WriteToFile(MemoryStream writer, bool isBigEndian);
        int GetSize();
    }

    public class ActorUnkBase : IActorExtraDataInterface
    {
        public int MoveOnInit { get; set; }
        public float ActivateImpulse { get; set; }
        public float DeactivateThreshold { get; set; }
        public float HitPoints { get; set; }
        public int MaterialID { get; set; }
        public float StaticFriction { get; set; }
        public float DynamicFriction { get; set; }
        public float Restitution { get; set; }

        [TypeConverter(typeof(Vector3Converter))]
        public Vector3 POPos { get; set; }

        [TypeConverter(typeof(Vector3Converter))]
        public Vector3 POSize { get; set; }

        public byte[] data;

        public int GetSize()
        {
            return 240;
        }

        public void ReadFromFile(MemoryStream reader, bool isBigEndian)
        {
            //float4 = reader.ReadSingle();
            //float8 = reader.ReadSingle();
            //floatC = reader.ReadSingle();
            //dword10 = Convert.ToInt32(reader.ReadSingle());
            //float14 = reader.ReadSingle();
            //float18 = reader.ReadSingle();
            //float1C = reader.ReadSingle();
            //dwordD4 = Convert.ToInt32(reader.ReadSingle());

            data = reader.ReadBytes(240);
        }

        public void WriteToFile(MemoryStream writer, bool isBigEndian)
        {
            writer.Write(data);
        }
    }

    public class ActorCleanEntity : IActorExtraDataInterface
    {
        public float Radius { get; set; }
        [TypeConverter(typeof(Vector3Converter))]
        public Vector3 BBoxSize { get; set; }
        public ActorCleanEntityFlags flags { get; set; }

        public int GetSize()
        {
            return 20;
        }

        public ActorCleanEntity(MemoryStream reader, bool isBigEndian)
        {
            ReadFromFile(reader, isBigEndian);
        }
        public void ReadFromFile(MemoryStream stream, bool isBigEndian)
        {
            Radius = stream.ReadSingle(isBigEndian);
            BBoxSize = Vector3Extenders.ReadFromFile(stream, isBigEndian);
            flags = (ActorCleanEntityFlags)stream.ReadInt32(isBigEndian);
        }

        public void WriteToFile(MemoryStream writer, bool isBigEndian)
        {
            writer.Write(Radius, isBigEndian);
            Vector3Extenders.WriteToFile(BBoxSize, writer, isBigEndian);
            writer.Write((int)flags, isBigEndian);
        }
    }

    public class ActorRadio : ActorUnkBase
    {
        int flags;
        float range;
        float nearRange;
        float volume;
        int curveID;
        string program;
        string playlist;
        string station;

        public ActorRadio(MemoryStream reader, bool isBigEndian)
        {
            ReadFromFile(reader, isBigEndian);
        }
        public new void ReadFromFile(MemoryStream reader, bool isBigEndian)
        {
            base.ReadFromFile(reader, isBigEndian);
            flags = reader.ReadInt32(isBigEndian);
            range = reader.ReadSingle(isBigEndian);
            nearRange = reader.ReadSingle(isBigEndian);
            volume = reader.ReadSingle(isBigEndian);
            curveID = reader.ReadInt32(isBigEndian);
            program = reader.ReadStringBuffer(256);
            playlist = reader.ReadStringBuffer(256);
            station = reader.ReadStringBuffer(256);
        }
    }

    public class ActorTrafficCar : IActorExtraDataInterface
    {
        int type;
        BoundingBox bbox;
        float unk0;
        float unk1;
        float unk2;
        float unk3;
        int maxElements;
        int pie;
        string tableName;
        string areaName;
        float carUnk4;
        float carUnk5;
        int carUnk6;
        int spawnedParking;
        int parking;
        string crewGenerator;
        int dirtyMin;
        int dirtyMax;
        int damageMin;
        int damageMax;
        int zero;


        public int Type { get { return type; } set { type = value; } }
        public BoundingBox BoundingBox { get { return bbox; } set { bbox = value; } }
        public float Unk0 { get { return unk0; } set { unk0 = value; } }
        public float Unk1 { get { return unk1; } set { unk1 = value; } }
        public float Unk2 { get { return unk2; } set { unk2 = value; } }
        public float Unk3 { get { return unk3; } set { unk3 = value; } }
        public int MaxElements { get { return maxElements; } set { maxElements = value; } }
        public int Pie { get { return pie; } set { pie = value; } }
        public string TableName { get { return tableName; } set { tableName = value; } }
        public string AreaName { get { return areaName; } set { areaName = value; } }
        public float CarUnk4 { get { return carUnk4; } set { carUnk4 = value; } }
        public float CarUnk5 { get { return carUnk5; } set { carUnk5 = value; } }
        public int CarUnk6 { get { return carUnk6; } set { carUnk6 = value; } }
        public int SpawnedParking { get { return spawnedParking; } set { spawnedParking = value; } }
        public int Parking { get { return parking; } set { parking = value; } }
        public string CrewGenerator { get { return crewGenerator; } set { crewGenerator = value; } }
        public int DirtyMin { get { return dirtyMin; } set { dirtyMin = value; } }
        public int DirtyMax { get { return dirtyMax; } set { dirtyMax = value; } }
        public int DamageMin { get { return damageMin; } set { damageMin = value; } }
        public int DamageMax { get { return damageMax; } set { damageMax = value; } }
        public int Zero { get { return zero; } set { zero = value; } }
        public ActorTrafficCar(MemoryStream reader, bool isBigEndian)
        {
            ReadFromFile(reader, isBigEndian);
        }

        public void ReadFromFile(MemoryStream reader, bool isBigEndian)
        {
            type = reader.ReadInt32(isBigEndian);
            bbox = BoundingBoxExtenders.ReadFromFile(reader, isBigEndian);
            unk0 = reader.ReadSingle(isBigEndian);
            unk1 = reader.ReadSingle(isBigEndian);
            unk2 = reader.ReadSingle(isBigEndian);
            unk3 = reader.ReadSingle(isBigEndian);
            maxElements = reader.ReadInt32(isBigEndian);
            pie = reader.ReadInt32(isBigEndian);
            tableName = reader.ReadStringBuffer(32).TrimEnd('\0');
            areaName = reader.ReadStringBuffer(64).TrimEnd('\0');
            carUnk4 = reader.ReadSingle(isBigEndian);
            carUnk5 = reader.ReadSingle(isBigEndian);
            carUnk6 = reader.ReadInt32(isBigEndian);
            spawnedParking = reader.ReadInt32(isBigEndian);
            parking = reader.ReadInt32(isBigEndian);
            crewGenerator = reader.ReadStringBuffer(32).TrimEnd('\0');
            dirtyMin = reader.ReadInt32(isBigEndian);
            dirtyMax = reader.ReadInt32(isBigEndian);
            damageMin = reader.ReadInt32(isBigEndian);
            damageMax = reader.ReadInt32(isBigEndian);
            zero = reader.ReadInt32(isBigEndian);
        }

        public void WriteToFile(MemoryStream writer, bool isBigEndian)
        {
            writer.Write(type, isBigEndian);
            BoundingBoxExtenders.WriteToFile(bbox, writer, isBigEndian);
            writer.Write(unk0, isBigEndian);
            writer.Write(unk1, isBigEndian);
            writer.Write(unk2, isBigEndian);
            writer.Write(unk3, isBigEndian);
            writer.Write(maxElements, isBigEndian);
            writer.Write(pie, isBigEndian);
            writer.WriteStringBuffer(32, tableName, '\0');
            writer.WriteStringBuffer(64, areaName, '\0');
            writer.Write(carUnk4, isBigEndian);
            writer.Write(carUnk5, isBigEndian);
            writer.Write(carUnk6, isBigEndian);
            writer.Write(spawnedParking, isBigEndian);
            writer.Write(parking, isBigEndian);
            writer.WriteStringBuffer(32, crewGenerator, '\0');
            writer.Write(dirtyMin, isBigEndian);
            writer.Write(dirtyMax, isBigEndian);
            writer.Write(damageMin, isBigEndian);
            writer.Write(damageMax, isBigEndian);
            writer.Write(zero, isBigEndian);
        }

        public int GetSize()
        {
            return 220;
        }
    }

    public class ActorTrafficHuman : IActorExtraDataInterface
    {
        int type;
        BoundingBox bbox;
        float unk0;
        float unk1;
        float unk2;
        float unk3;
        int maxElements;
        int pie;
        string tableName;
        string areaName;
        float zDistance;
        float agregationRange;
        int agregationCount;

        public int Type { get { return type; } set { type = value; } }
        public BoundingBox BoundingBox { get { return bbox; } set { bbox = value; } }
        public float Unk0 { get { return unk0; } set { unk0 = value; } }
        public float Unk1 { get { return unk1; } set { unk1 = value; } }
        public float Unk2 { get { return unk2; } set { unk2 = value; } }
        public float Unk3 { get { return unk3; } set { unk3 = value; } }
        public int MaxElements { get { return maxElements; } set { maxElements = value; } }
        public int Pie { get { return pie; } set { pie = value; } }
        public string TableName { get { return tableName; } set { tableName = value; } }
        public string AreaName { get { return areaName; } set { areaName = value; } }
        public float ZDistance { get { return zDistance; } set { zDistance = value; } }
        public float AgregationRange { get { return agregationRange; } set { agregationRange = value; } }
        public int AgregationCount { get { return agregationCount; } set { agregationCount = value; } }

        public ActorTrafficHuman(MemoryStream reader, bool isBigEndian)
        {
            ReadFromFile(reader, isBigEndian);
        }

        public void ReadFromFile(MemoryStream reader, bool isBigEndian)
        {
            type = reader.ReadInt32(isBigEndian);
            bbox = BoundingBoxExtenders.ReadFromFile(reader, isBigEndian);
            unk0 = reader.ReadSingle(isBigEndian);
            unk1 = reader.ReadSingle(isBigEndian);
            unk2 = reader.ReadSingle(isBigEndian);
            unk3 = reader.ReadSingle(isBigEndian);
            maxElements = reader.ReadInt32(isBigEndian);
            pie = reader.ReadInt32(isBigEndian);
            tableName = reader.ReadStringBuffer(32).TrimEnd('\0');
            areaName = reader.ReadStringBuffer(64).TrimEnd('\0');
            zDistance = reader.ReadSingle(isBigEndian);
            agregationRange = reader.ReadSingle(isBigEndian);
            agregationCount = reader.ReadInt32(isBigEndian);
        }

        public void WriteToFile(MemoryStream writer, bool isBigEndian)
        {
            writer.Write(type, isBigEndian);
            BoundingBoxExtenders.WriteToFile(bbox, writer, isBigEndian);
            writer.Write(unk0, isBigEndian);
            writer.Write(unk1, isBigEndian);
            writer.Write(unk2, isBigEndian);
            writer.Write(unk3, isBigEndian);
            writer.Write(maxElements, isBigEndian);
            writer.Write(pie, isBigEndian);
            writer.WriteStringBuffer(32, tableName, '\0');
            writer.WriteStringBuffer(64, areaName, '\0');
            writer.Write(zDistance, isBigEndian);
            writer.Write(agregationRange, isBigEndian);
            writer.Write(agregationCount, isBigEndian);
        }

        public int GetSize()
        {
            return 160;
        }
    }

    public class ActorTrafficTrain : IActorExtraDataInterface
    {
        int type;
        BoundingBox bbox;
        float unk0;
        float unk1;
        float unk2;
        float unk3;
        int maxElements;
        int pie;
        string tableName;
        string areaName;
        string crewGenerator;

        public int Type { get { return type; } set { type = value; } }
        public BoundingBox BoundingBox { get { return bbox; } set { bbox = value; } }
        public float Unk0 { get { return unk0; } set { unk0 = value; } }
        public float Unk1 { get { return unk1; } set { unk1 = value; } }
        public float Unk2 { get { return unk2; } set { unk2 = value; } }
        public float Unk3 { get { return unk3; } set { unk3 = value; } }
        public int MaxElements { get { return maxElements; } set { maxElements = value; } }
        public int Pie { get { return pie; } set { pie = value; } }
        public string TableName { get { return tableName; } set { tableName = value; } }
        public string AreaName { get { return areaName; } set { areaName = value; } }
        public string CrewGenerator { get { return crewGenerator; } set { crewGenerator = value; } }

        public ActorTrafficTrain(MemoryStream reader, bool isBigEndian)
        {
            ReadFromFile(reader, isBigEndian);
        }

        public void ReadFromFile(MemoryStream reader, bool isBigEndian)
        {
            type = reader.ReadInt32(isBigEndian);
            bbox = BoundingBoxExtenders.ReadFromFile(reader, isBigEndian);
            unk0 = reader.ReadSingle(isBigEndian);
            unk1 = reader.ReadSingle(isBigEndian);
            unk2 = reader.ReadSingle(isBigEndian);
            unk3 = reader.ReadSingle(isBigEndian);
            maxElements = reader.ReadInt32(isBigEndian);
            pie = reader.ReadInt32(isBigEndian);
            tableName = reader.ReadStringBuffer(32).TrimEnd('\0');
            areaName = reader.ReadStringBuffer(64).TrimEnd('\0');
            crewGenerator = reader.ReadStringBuffer(32).TrimEnd('\0');
        }

        public void WriteToFile(MemoryStream writer, bool isBigEndian)
        {
            writer.Write(type, isBigEndian);
            BoundingBoxExtenders.WriteToFile(bbox, writer, isBigEndian);
            writer.Write(unk0, isBigEndian);
            writer.Write(unk1, isBigEndian);
            writer.Write(unk2, isBigEndian);
            writer.Write(unk3, isBigEndian);
            writer.Write(maxElements, isBigEndian);
            writer.Write(pie, isBigEndian);
            writer.WriteStringBuffer(32, tableName, '\0');
            writer.WriteStringBuffer(64, areaName, '\0');
            writer.WriteStringBuffer(32, crewGenerator, '\0');
        }

        public int GetSize()
        {
            return 180;
        }
    }

    public class ActorWardrobe : IActorExtraDataInterface
    {
        byte[] cameraPos;
        string doorName;
        string soundName;
        string humanAnimationName;
        int textID;
        float unk0;
        int testPrimitive;
        byte[] posData;

        public byte[] CameraPos { get { return cameraPos;  } set { cameraPos = value; } }
        public string DoorName { get { return doorName; } set { doorName = value; } }
        public string SoundName { get { return soundName; } set { soundName = value; } }
        public string HumanAnimationName { get { return humanAnimationName; } set { humanAnimationName = value; } }
        public int TextID { get { return textID; } set { textID = value; } }
        public float Unk0 { get { return unk0; } set { unk0 = value; } }
        public int TestPrimitive { get { return testPrimitive; } set { testPrimitive = value; } }
        public byte[] PosData { get { return posData; } set { posData = value; } }

        public ActorWardrobe(MemoryStream reader, bool isBigEndian)
        {
            ReadFromFile(reader, isBigEndian);
        }
        public void ReadFromFile(MemoryStream reader, bool isBigEndian)
        {
            cameraPos = reader.ReadBytes(72);
            doorName = reader.ReadStringBuffer(32).TrimEnd('\0');
            soundName = reader.ReadStringBuffer(32).TrimEnd('\0');
            humanAnimationName = reader.ReadStringBuffer(32).TrimEnd('\0');
            textID = reader.ReadInt32(isBigEndian);
            unk0 = reader.ReadSingle(isBigEndian);
            testPrimitive = reader.ReadInt32(isBigEndian);
            posData = reader.ReadBytes(28);
        }

        public void WriteToFile(MemoryStream writer, bool isBigEndian)
        {
            writer.Write(cameraPos);
            writer.WriteStringBuffer(32, doorName, '\0');
            writer.WriteStringBuffer(32, soundName, '\0');
            writer.WriteStringBuffer(32, humanAnimationName, '\0');
            writer.Write(textID, isBigEndian);
            writer.Write(unk0, isBigEndian);
            writer.Write(testPrimitive, isBigEndian);
            writer.Write(posData);
        }

        public int GetSize()
        {
            return 208;
        }
    }

    public class ActorLight : IActorExtraDataInterface
    {
        int size;
        byte[] padding;
        int unk01;
        byte unk02;
        Vector3 unk03;
        Vector3 unk04;
        Vector3 unk05;
        Vector3 unk06;
        int unk07;
        int unk08;
        int unk09;
        byte count;
        int unk10;
        Hash[] sceneLinks;
        Hash[] frameLinks;
        int[] frameIdxLinks;
        int flags;
        float[] unkFloat1 = new float[7];
        int unk_int;
        float[] unkFloat2 = new float[5];
        byte unk_byte1;
        float[] unkFloat3 = new float[17];
        byte unk_byte2;
        float[] unkFloat4 = new float[5];
        Hash nameLight;
        int unk_int2;
        float[] unkFloat5 = new float[20];
        Hash[] names = new Hash[4];
        Vector3 unkVector1;
        Vector3 unkVector2;
        byte unk_byte3;
        Vector3 unkVector3;
        Vector3 unkVector4;
        Vector3 unkVector5;
        Vector3 unkVector6;
        int instanced;
        int type;

        public int Unk01 {
            get { return unk01; }
            set { unk01 = value; }
        }
        public byte Unk02 {
            get { return unk02; }
            set { unk02 = value; }
        }
        public Vector3 Unk3 {
            get { return unk03; }
            set { unk03 = value; }
        }
        public Vector3 Unk4 {
            get { return unk04; }
            set { unk04 = value; }
        }
        public Vector3 Unk5 {
            get { return unk05; }
            set { unk05 = value; }
        }
        public Vector3 Unk6 {
            get { return unk06; }
            set { unk06 = value; }
        }
        public int Unk07 {
            get { return unk07; }
            set { unk07 = value; }
        }
        public int Unk08 {
            get { return unk08; }
            set { unk08 = value; }
        }
        public int Unk09 {
            get { return unk09; }
            set { unk09 = value; }
        }
        public byte Count {
            get { return count; }
            set { count = value; }
        }
        public int Unk10 {
            get { return unk10; }
            set { unk10 = value; }
        }
        public Hash[] SceneLinks {
            get { return sceneLinks; }
            set { sceneLinks = value; }
        }
        public Hash[] FrameLinks {
            get { return frameLinks; }
            set { frameLinks = value; }
        }
        public int[] FrameIDXLinks {
            get { return frameIdxLinks; }
            set { frameIdxLinks = value; }
        }
        public float[] UnkFloats1 {
            get { return unkFloat1; }
            set { unkFloat1 = value; }
        }
        public int UnkInt1 {
            get { return unk_int; }
            set { unk_int = value; }
        }
        public float[] UnkFloats2 {
            get { return unkFloat2; }
            set { unkFloat2 = value; }
        }
        public byte UnkByte1 {
            get { return unk_byte1; }
            set { unk_byte1 = value; }
        }
        public float[] UnkFloats3 {
            get { return unkFloat3; }
            set { unkFloat3 = value; }
        }
        public byte UnkByte2 {
            get { return unk_byte2; }
            set { unk_byte2 = value; }
        }
        public float[] UnkFloats4 {
            get { return unkFloat4; }
            set { unkFloat4 = value; }
        }
        public Hash NameLight {
            get { return nameLight; }
            set { nameLight = value; }
        }
        public int UnkInt2 {
            get { return unk_int2; }
            set { unk_int2 = value; }
        }
        public float[] UnkFloats5 {
            get { return unkFloat5; }
            set { unkFloat5 = value; }
        }
        public Hash[] UnkHashes {
            get { return names; }
            set { names = value; }
        }
        public Vector3 UnkVector1 {
            get { return unkVector1; }
            set { unkVector1 = value; }
        }
        public Vector3 UnkVector2 {
            get { return unkVector2; }
            set { unkVector2 = value; }
        }
        public byte UnkByte3 {
            get { return unk_byte3; }
            set { unk_byte3 = value; }
        }
        public Vector3 UnkVector3 {
            get { return unkVector3; }
            set { unkVector3 = value; }
        }
        public Vector3 UnkVector4 {
            get { return unkVector4; }
            set { unkVector4 = value; }
        }
        public Vector3 UnkVector5 {
            get { return unkVector5; }
            set { unkVector5 = value; }
        }
        public Vector3 UnkVector6 {
            get { return unkVector6; }
            set { unkVector6 = value; }
        }
        public int Instanced {
            get { return instanced; }
            set { instanced = value; }
        }
        public int Type {
            get { return type; }
            set { type = value; }
        }
        public ActorLight(MemoryStream reader, bool isBigEndian)
        {
            ReadFromFile(reader, isBigEndian);
        }

        public void ReadFromFile(MemoryStream reader, bool isBigEndian)
        {
            size = reader.ReadInt32(isBigEndian);
            if (size < 2305)
            {
                padding = reader.ReadBytes(9);
                unk01 = reader.ReadInt32(isBigEndian);
                unk02 = reader.ReadByte8();
                unk03 = Vector3Extenders.ReadFromFile(reader, isBigEndian);
                unk04 = Vector3Extenders.ReadFromFile(reader, isBigEndian);
                unk05 = Vector3Extenders.ReadFromFile(reader, isBigEndian);
                unk06 = Vector3Extenders.ReadFromFile(reader, isBigEndian);
                unk07 = reader.ReadInt32(isBigEndian);
                unk08 = reader.ReadInt32(isBigEndian);
                unk09 = reader.ReadInt32(isBigEndian);
                count = reader.ReadByte8();
                unk10 = reader.ReadInt32(isBigEndian);

                frameLinks = new Hash[count];
                sceneLinks = new Hash[count];
                frameIdxLinks = new int[count];
                for (int i = 0; i < count; i++)
                {
                    sceneLinks[i] = new Hash(reader, isBigEndian);
                    frameLinks[i] = new Hash(reader, isBigEndian);
                    frameIdxLinks[i] = reader.ReadInt32(isBigEndian);
                }

                //flags = reader.ReadInt32();

                for (int i = 0; i < 7; i++)
                    unkFloat1[i] = reader.ReadSingle(isBigEndian);

                unk_int = reader.ReadInt32(isBigEndian);

                for (int i = 0; i < 5; i++)
                    unkFloat2[i] = reader.ReadSingle(isBigEndian);

                unk_byte1 = reader.ReadByte8();

                for (int i = 0; i < 17; i++)
                    unkFloat3[i] = reader.ReadSingle(isBigEndian);

                unk_byte2 = reader.ReadByte8();

                for (int i = 0; i < 5; i++)
                    unkFloat4[i] = reader.ReadSingle(isBigEndian);

                nameLight = new Hash(reader, isBigEndian);

                unk_int2 = reader.ReadInt32(isBigEndian);

                for (int i = 0; i < 20; i++)
                    unkFloat5[i] = reader.ReadSingle(isBigEndian);

                for (int i = 0; i < 4; i++)
                    names[i] = new Hash(reader, isBigEndian);

                unkVector1 = Vector3Extenders.ReadFromFile(reader, isBigEndian);
                unkVector2 = Vector3Extenders.ReadFromFile(reader, isBigEndian);
                unk_byte3 = reader.ReadByte8();
                unkVector3 = Vector3Extenders.ReadFromFile(reader, isBigEndian);
                unkVector4 = Vector3Extenders.ReadFromFile(reader, isBigEndian);
                unkVector5 = Vector3Extenders.ReadFromFile(reader, isBigEndian);
                unkVector6 = Vector3Extenders.ReadFromFile(reader, isBigEndian);
            }
            reader.Seek(2308, SeekOrigin.Begin);
            instanced = reader.ReadInt32(isBigEndian);
            type = reader.ReadInt32(isBigEndian);
        }

        public void WriteToFile(MemoryStream writer, bool isBigEndian)
        {
            writer.Write(new byte[2316]);
            writer.Seek(0, SeekOrigin.Begin);
            writer.Write(size, isBigEndian);
            writer.Write(this.padding);
            writer.Write(unk01, isBigEndian);
            writer.WriteByte(unk02);
            Vector3Extenders.WriteToFile(unk03, writer, isBigEndian);
            Vector3Extenders.WriteToFile(unk04, writer, isBigEndian);
            Vector3Extenders.WriteToFile(unk05, writer, isBigEndian);
            Vector3Extenders.WriteToFile(unk06, writer, isBigEndian);
            writer.Write(unk07, isBigEndian);
            writer.Write(unk08, isBigEndian);
            writer.Write(unk09, isBigEndian);
            writer.WriteByte(count);
            writer.Write(unk10, isBigEndian);

            for (int i = 0; i < count; i++)
            {
                sceneLinks[i].WriteToFile(writer, isBigEndian);
                frameLinks[i].WriteToFile(writer, isBigEndian);
                writer.Write(frameIdxLinks[i], isBigEndian);
            }

            for (int i = 0; i < 7; i++)
                writer.Write(unkFloat1[i], isBigEndian);

            writer.Write(unk_int, isBigEndian);

            for (int i = 0; i < 5; i++)
                writer.Write(unkFloat2[i], isBigEndian);

            writer.WriteByte(unk_byte1);

            for (int i = 0; i < 17; i++)
                writer.Write(unkFloat3[i], isBigEndian);

            writer.WriteByte(unk_byte2);

            for (int i = 0; i < 5; i++)
                writer.Write(unkFloat4[i], isBigEndian);

            nameLight.WriteToFile(writer, isBigEndian);

            writer.Write(unk_int2, isBigEndian);

            for (int i = 0; i != 20; i++)
                writer.Write(unkFloat5[i], isBigEndian);

            for (int i = 0; i != 4; i++)
                names[i].WriteToFile(writer, isBigEndian);

            unkVector1.WriteToFile(writer, isBigEndian);
            unkVector2.WriteToFile(writer, isBigEndian);
            writer.WriteByte(unk_byte3);
            unkVector3.WriteToFile(writer, isBigEndian);
            unkVector4.WriteToFile(writer, isBigEndian);
            unkVector5.WriteToFile(writer, isBigEndian);
            unkVector6.WriteToFile(writer, isBigEndian);
            writer.Seek(2308, SeekOrigin.Begin);
            writer.Write(instanced, isBigEndian);
            writer.Write(type, isBigEndian);
        }

        public int GetSize()
        {
            return 2316;
        }
    }

    public class ActorDoor : IActorExtraDataInterface
    {
        byte[] data;
        byte disabled;
        byte closesPortals;
        byte physicalOpen;
        byte physicalClose;
        float closedMagnitude;
        byte automaticOpen;
        byte automaticClose;
        short automaticCloseDelay; //MAYBE??
        int unk0;
        float unk1;
        int locked;
        int lockedSoundID;
        int lockTime;
        int unlockTime;
        int lockSoundID;
        int unlockSoundID;
        int lockpickSoundID;
        int lockpickClicksCount;
        int openingSoundID;
        int closingSoundID;
        int closingSound2ID;
        int closingSound3ID;
        int closingSoundMagnitude;
        int closingSound2Magnitude;
        int closingSound3Magnitude;
        int movingSoundID;
        int kickingSoundID;
        int kickable;
        int closedSoundID;
        int openHint;
        int closeHint;
        int lockpickHint;
        int kickHint;
        int actorActionsEnabled;
        int pushAwayMode;
        int pushAwayReaction;

        public byte[] Data { get { return data; } set { data = value; } }
        public byte Disabled { get { return disabled; } set { disabled = value; } }
        public byte ClosesPortals { get { return closesPortals; } set { closesPortals = value; } }
        public byte PhysicalOpen { get { return physicalOpen; } set { physicalOpen = value; } }
        public byte PhysicalClose { get { return physicalClose; } set { physicalClose = value; } }
        public float ClosedMagnitude { get { return closedMagnitude; } set { closedMagnitude = value; } }
        public byte AutomaticOpen { get { return automaticOpen; } set { automaticOpen = value; } }
        public byte AutomaticClose { get { return automaticClose; } set { automaticClose = value; } }
        public short AutomaticCloseDelay { get { return automaticCloseDelay; } set { automaticCloseDelay = value; } }
        public int Unk0 { get { return unk0; } set { unk0 = value; } }
        public float Unk1 { get { return unk1; } set { unk1 = value; } }
        public int Locked { get { return locked; } set { locked = value; } }
        public int LockedSoundID { get { return lockedSoundID; } set { lockedSoundID = value; } }
        public int LockTime { get { return lockTime; } set { lockTime = value; } }
        public int UnlockTime { get { return unlockTime; } set { unlockTime = value; } }
        public int LockSoundID { get { return lockSoundID; } set { lockSoundID = value; } }
        public int UnlockSoundID { get { return unlockSoundID; } set { unlockSoundID = value; } }
        public int LockpickSoundID { get { return lockpickSoundID; } set { lockpickSoundID = value; } }
        public int LockpickClicksCount { get { return lockpickClicksCount; } set { lockpickClicksCount = value; } }
        public int OpeningSoundID { get { return openingSoundID; } set { openingSoundID = value; } }
        public int ClosingSoundID { get { return closingSoundID; } set { closingSoundID = value; } }
        public int ClosingSound2ID { get { return closingSound2ID; } set { closingSound2ID = value; } }
        public int ClosingSound3ID { get { return closingSound3ID; } set { closingSound3ID = value; } }
        public int ClosingSoundMagnitude { get { return closingSoundMagnitude; } set { closingSoundMagnitude = value; } }
        public int ClosingSound2Magnitude { get { return closingSound2Magnitude; } set { closingSound2Magnitude = value; } }
        public int ClosingSound3Magnitude { get { return closingSound3Magnitude; } set { closingSound3Magnitude = value; } }
        public int MovingSoundID { get { return movingSoundID; } set { movingSoundID = value; } }
        public int KickingSoundID { get { return kickingSoundID; } set { kickingSoundID = value; } }
        public int Kickable { get { return kickable; } set { kickable = value; } }
        public int ClosedSoundID { get { return closedSoundID; } set { closedSoundID = value; } }
        public int OpenHint { get { return openHint; } set { openHint = value; } }
        public int CloseHint { get { return closeHint; } set { closeHint = value; } }
        public int LockpickHint { get { return lockpickHint; } set { lockpickHint = value; } }
        public int KickHint { get { return kickHint; } set { kickHint = value; } }
        public int ActorActionsEnabled { get { return actorActionsEnabled; } set { actorActionsEnabled = value; } }
        public int PushAwayMode { get { return pushAwayMode; } set { pushAwayMode = value; } }
        public int PushAwayReaction { get { return pushAwayReaction; } set { pushAwayReaction = value; } }

        public ActorDoor(MemoryStream reader, bool isBigEndian)
        {
            ReadFromFile(reader, isBigEndian);
        }
        public void ReadFromFile(MemoryStream reader, bool isBigEndian)
        {
            data = reader.ReadBytes(240);
            disabled = reader.ReadByte8();
            closesPortals = reader.ReadByte8();
            physicalOpen = reader.ReadByte8();
            physicalClose = reader.ReadByte8();
            closedMagnitude = reader.ReadSingle(isBigEndian);
            automaticOpen = reader.ReadByte8();
            automaticClose = reader.ReadByte8();
            automaticCloseDelay = reader.ReadInt16(isBigEndian);
            unk0 = reader.ReadInt32(isBigEndian);
            unk1 = reader.ReadSingle(isBigEndian);
            locked = reader.ReadInt32(isBigEndian);
            lockedSoundID = reader.ReadInt32(isBigEndian);
            lockTime = reader.ReadInt32(isBigEndian);
            unlockTime = reader.ReadInt32(isBigEndian);
            lockSoundID = reader.ReadInt32(isBigEndian);
            unlockSoundID = reader.ReadInt32(isBigEndian);
            lockpickSoundID = reader.ReadInt32(isBigEndian);
            lockpickClicksCount = reader.ReadInt32(isBigEndian);
            openingSoundID = reader.ReadInt32(isBigEndian);
            closingSoundID = reader.ReadInt32(isBigEndian);
            closingSound2ID = reader.ReadInt32(isBigEndian);
            closingSound3ID = reader.ReadInt32(isBigEndian);
            closingSoundMagnitude = reader.ReadInt32(isBigEndian);
            closingSound2Magnitude = reader.ReadInt32(isBigEndian);
            closingSound3Magnitude = reader.ReadInt32(isBigEndian);
            movingSoundID = reader.ReadInt32(isBigEndian);
            kickingSoundID = reader.ReadInt32(isBigEndian);
            kickable = reader.ReadInt32(isBigEndian);
            closedSoundID = reader.ReadInt32(isBigEndian);
            openHint = reader.ReadInt32(isBigEndian);
            closeHint = reader.ReadInt32(isBigEndian);
            lockpickHint = reader.ReadInt32(isBigEndian);
            kickHint = reader.ReadInt32(isBigEndian);
            actorActionsEnabled = reader.ReadInt32(isBigEndian);
            pushAwayMode = reader.ReadInt32(isBigEndian);
            pushAwayReaction = reader.ReadInt32(isBigEndian);
        }

        public void WriteToFile(MemoryStream writer, bool isBigEndian)
        {
            writer.Write(data);
            writer.WriteByte(disabled);
            writer.WriteByte(closesPortals);
            writer.WriteByte(physicalOpen);
            writer.WriteByte(physicalClose);
            writer.Write(closedMagnitude, isBigEndian);
            writer.WriteByte(automaticOpen);
            writer.WriteByte(automaticClose);
            writer.Write(automaticCloseDelay, isBigEndian);
            writer.Write(unk0, isBigEndian);
            writer.Write(unk1, isBigEndian);
            writer.Write(locked, isBigEndian);
            writer.Write(lockedSoundID, isBigEndian);
            writer.Write(lockTime, isBigEndian);
            writer.Write(unlockTime, isBigEndian);
            writer.Write(lockSoundID, isBigEndian);
            writer.Write(unlockSoundID, isBigEndian);
            writer.Write(lockpickSoundID, isBigEndian);
            writer.Write(lockpickClicksCount, isBigEndian);
            writer.Write(openingSoundID, isBigEndian);
            writer.Write(closingSoundID, isBigEndian);
            writer.Write(closingSound2ID, isBigEndian);
            writer.Write(closingSound3ID, isBigEndian);
            writer.Write(closingSoundMagnitude, isBigEndian);
            writer.Write(closingSound2Magnitude, isBigEndian);
            writer.Write(closingSound3Magnitude, isBigEndian);
            writer.Write(movingSoundID, isBigEndian);
            writer.Write(kickingSoundID, isBigEndian);
            writer.Write(kickable, isBigEndian);
            writer.Write(closedSoundID, isBigEndian);
            writer.Write(openHint, isBigEndian);
            writer.Write(closeHint, isBigEndian);
            writer.Write(lockpickHint, isBigEndian);
            writer.Write(kickHint, isBigEndian);
            writer.Write(actorActionsEnabled, isBigEndian);
            writer.Write(pushAwayMode, isBigEndian);
            writer.Write(pushAwayReaction, isBigEndian);
        }

        public int GetSize()
        {
            return 364;
        }
    }

    public class ActorSoundEntity : IActorExtraDataInterface
    {
        ActorSoundEntityBehaviourFlags behFlags;
        int type;
        int behaviourType;
        float volume;
        float pitch;
        string file;
        float randomPauseMin;
        float randomPauseMax;
        float randomGroupPauseMin;
        float randomGroupPauseMax;
        int randomGroupSoundsMin;
        int randomGroupSoundsMax;
        float randomVolumeMin;
        float randomVolumeMax;
        float randomPitchMin;
        float randomPitchMax;
        float randomPosRangeX;
        float randomPosRangeY;
        float randomPosRangeZ;
        ActorSoundEntityPlayType playFlags;
        string[] randomWaves;

        float near;
        float far;
        //WHEREVER YOU AREEEE!!
        float monoDistance;
        int curveID;
        float innerAngle;
        float outerAngle;
        float outerVolume;

        [Editor(typeof(FlagEnumUIEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public ActorSoundEntityBehaviourFlags BehaviourFlags {
            get { return behFlags; }
            set { behFlags = value; }
        }
        public int Type {
            get { return type; }
            set { type = value; }
        }
        public int BehaviourType {
            get { return behaviourType; }
            set { behaviourType = value; }
        }
        public float Volume {
            get { return volume; }
            set { volume = value; }
        }
        public float Pitch {
            get { return pitch; }
            set { pitch = value; }
        }
        public string File {
            get { return file; }
            set { file = value; }
        }
        public float RandomGroupPauseMax {
            get { return randomGroupPauseMax; }
            set { randomGroupPauseMax = value; }
        }
        public float RandomGroupPauseMin {
            get { return randomGroupPauseMin; }
            set { randomGroupPauseMin = value; }
        }
        public float RandomPauseMin {
            get { return randomPauseMin; }
            set { randomPauseMin = value; }
        }
        public float RandomPauseMax {
            get { return randomPauseMax; }
            set { randomPauseMax = value; }
        }
        public int RandomGroupSoundsMax {
            get { return randomGroupSoundsMax; }
            set { randomGroupSoundsMax = value; }
        }
        public int RandomGroupSoundsMin {
            get { return randomGroupSoundsMin; }
            set { randomGroupSoundsMin = value; }
        }
        public float RandomVolumeMin {
            get { return randomVolumeMin; }
            set { randomVolumeMin = value; }
        }
        public float RandomVolumeMax {
            get { return randomVolumeMax; }
            set { randomVolumeMax = value; }
        }
        public float RandomPitchMin {
            get { return randomPitchMin; }
            set { randomPitchMin = value; }
        }
        public float RandomPitchMax {
            get { return randomPitchMax; }
            set { randomPitchMax = value; }
        }
        public float RandomPosRangeX {
            get { return randomPosRangeX; }
            set { randomPosRangeX = value; }
        }
        public float RandomPosRangeY {
            get { return randomPosRangeY; }
            set { randomPosRangeY = value; }
        }
        public float RandomPosRangeZ {
            get { return randomPosRangeZ; }
            set { randomPosRangeZ = value; }
        }

        [Editor(typeof(FlagEnumUIEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public ActorSoundEntityPlayType PlayFlags {
            get { return playFlags; }
            set { playFlags = value; }
        }
        public string[] RandomWaves {
            get { return randomWaves; }
            set { randomWaves = value; }
        }
        public float Near {
            get { return near; }
            set { near = value; }
        }
        public float Far {
            get { return far; }
            set { far = value; }
        }
        public float MonoDistance {
            get { return monoDistance; }
            set { monoDistance = value; }
        }
        public int CurveID {
            get { return curveID; }
            set { curveID = value; }
        }
        public float InnerAngle {
            get { return innerAngle; }
            set { innerAngle = value; }
        }
        public float OuterAngle {
            get { return outerAngle; }
            set { outerAngle = value; }
        }
        public float OuterVolume {
            get { return outerVolume; }
            set { outerVolume = value; }
        }

        public ActorSoundEntity(MemoryStream reader, bool isBigEndian)
        {
            ReadFromFile(reader, isBigEndian);
        }

        public int GetSize()
        {
            return 592;
        }

        public void ReadFromFile(MemoryStream reader, bool isBigEndian)
        {
            behFlags = (ActorSoundEntityBehaviourFlags)reader.ReadInt32(isBigEndian);
            type = reader.ReadInt32(isBigEndian);
            behaviourType = reader.ReadInt32(isBigEndian);
            volume = reader.ReadSingle(isBigEndian);
            pitch = reader.ReadSingle(isBigEndian);
            file = reader.ReadStringBuffer(80);
            if(behaviourType == 20)
            {
                int seek = 0x21C;
                reader.Seek(seek, SeekOrigin.Begin);
                randomPauseMin = reader.ReadSingle(isBigEndian);
                randomPauseMax = reader.ReadSingle(isBigEndian);
                randomGroupPauseMin = reader.ReadSingle(isBigEndian);
                randomGroupPauseMax = reader.ReadSingle(isBigEndian);
                randomGroupSoundsMin = reader.ReadInt32(isBigEndian);
                randomGroupSoundsMax = reader.ReadInt32(isBigEndian);
                randomVolumeMin = reader.ReadSingle(isBigEndian);
                randomVolumeMax = reader.ReadSingle(isBigEndian);
                randomPitchMin = reader.ReadSingle(isBigEndian);
                randomPitchMax = reader.ReadSingle(isBigEndian);
                randomPosRangeX = reader.ReadSingle(isBigEndian);
                randomPosRangeY = reader.ReadSingle(isBigEndian);
                randomPosRangeZ = reader.ReadSingle(isBigEndian);

                seek = 0x84;
                reader.Seek(seek, SeekOrigin.Begin);
                playFlags = (ActorSoundEntityPlayType)reader.ReadByte();
                randomWaves = new string[5];

                for (int i = 0; i < 5; i++)
                {
                    randomWaves[i] = reader.ReadStringBuffer(80).TrimEnd('\0');
                    reader.ReadByte();
                }
            }
            reader.Seek(100, SeekOrigin.Begin);
            reader.ReadInt32(isBigEndian);
            switch (type)
            {
                case 20:
                    near = reader.ReadSingle(isBigEndian);
                    far = reader.ReadSingle(isBigEndian);
                    monoDistance = reader.ReadSingle(isBigEndian);
                    curveID = reader.ReadInt32(isBigEndian);
                    break;
                case 15:
                    near = reader.ReadSingle(isBigEndian);
                    far = reader.ReadSingle(isBigEndian);
                    curveID = reader.ReadInt32(isBigEndian);
                    break;
                case 30:
                    near = reader.ReadSingle(isBigEndian);
                    far = reader.ReadSingle(isBigEndian);
                    curveID = reader.ReadInt32(isBigEndian);
                    reader.Seek(120, SeekOrigin.Begin);
                    innerAngle = reader.ReadSingle(isBigEndian);
                    outerAngle = reader.ReadSingle(isBigEndian);
                    outerVolume = reader.ReadSingle(isBigEndian);
                    break;
                case 10:
                    break;
                default:
                    break;
            }
        }

        public void WriteToFile(MemoryStream writer, bool isBigEndian)
        {
            writer.Write(new byte[592]);
            writer.Seek(0, SeekOrigin.Begin);
            writer.Write((int)behFlags, isBigEndian);
            writer.Write(type, isBigEndian);
            writer.Write(behaviourType, isBigEndian);
            writer.Write(volume, isBigEndian);
            writer.Write(pitch, isBigEndian);
            writer.WriteStringBuffer(80, file, '\0');
            if (behaviourType == 20)
            {
                writer.Seek(0x21C, SeekOrigin.Begin);
                writer.Write(randomPauseMin, isBigEndian);
                writer.Write(randomPauseMax, isBigEndian);
                writer.Write(randomGroupPauseMin, isBigEndian);
                writer.Write(randomGroupPauseMax, isBigEndian);
                writer.Write(randomGroupSoundsMin, isBigEndian);
                writer.Write(randomGroupSoundsMax, isBigEndian);
                writer.Write(randomVolumeMin, isBigEndian);
                writer.Write(randomVolumeMax, isBigEndian);
                writer.Write(randomPitchMin, isBigEndian);
                writer.Write(randomPitchMax, isBigEndian);
                writer.Write(randomPosRangeX, isBigEndian);
                writer.Write(randomPosRangeY, isBigEndian);
                writer.Write(randomPosRangeZ, isBigEndian);
                writer.Seek(0x84, SeekOrigin.Begin);
                writer.WriteByte((byte)playFlags);
                for (int i = 0; i < 5; i++)
                {
                    string wave = string.IsNullOrEmpty(randomWaves[i]) == true ? new string(new char[] { '\0' }) : randomWaves[i];
                    writer.WriteStringBuffer(80, wave, '\0');
                    writer.WriteByte(0);
                }
            }
            writer.Seek(100, SeekOrigin.Begin);
            writer.Write(0, isBigEndian);
            switch (type)
            {
                case 20:
                    writer.Write(near, isBigEndian);
                    writer.Write(far, isBigEndian);
                    writer.Write(monoDistance, isBigEndian);
                    writer.Write(curveID, isBigEndian);
                    break;
                case 15:
                    writer.Write(near, isBigEndian);
                    writer.Write(far, isBigEndian);
                    writer.Write(curveID, isBigEndian);
                    break;
                case 30:
                    writer.Write(near, isBigEndian);
                    writer.Write(far, isBigEndian);
                    writer.Write(curveID, isBigEndian);
                    writer.Seek(120, SeekOrigin.Begin);
                    writer.Write(innerAngle, isBigEndian);
                    writer.Write(outerAngle, isBigEndian);
                    writer.Write(outerVolume, isBigEndian);
                    break;
                case 10:
                    break;
                default:
                    break;
            }
        }
    }

    public class ActorSpikeStrip : IActorExtraDataInterface
    {
        float length;

        public float Length {
            get { return length; }
            set { length = value; }
        }

        public ActorSpikeStrip(MemoryStream reader, bool isBigEndian)
        {
            ReadFromFile(reader, isBigEndian);
        }

        public void ReadFromFile(MemoryStream reader, bool isBigEndian)
        {
            length = reader.ReadSingle(isBigEndian);
        }

        public void WriteToFile(MemoryStream writer, bool isBigEndian)
        {
            writer.Write(length, isBigEndian);
        }

        public int GetSize()
        {
            return 4;
        }
    }


    public class ActorAircraft : IActorExtraDataInterface
    {
        int soundMotorID;

        public int SoundMotorID {
            get { return soundMotorID; }
            set { soundMotorID = value; }
        }

        public ActorAircraft(MemoryStream reader, bool isBigEndian)
        {
            ReadFromFile(reader, isBigEndian);
        }

        public void ReadFromFile(MemoryStream reader, bool isBigEndian)
        {
            soundMotorID = reader.ReadInt32(isBigEndian);
        }

        public void WriteToFile(MemoryStream writer, bool isBigEndian)
        {
            writer.Write(soundMotorID, isBigEndian);
        }

        public int GetSize()
        {
            return 4;
        }
    }

    public class ActorItem : IActorExtraDataInterface
    {
        public interface IItem { }
        public class ItemScript : IItem
        {
            string scriptEvent;
            int textID;
            int sentTestAction;

            public string ScriptEvent {
                get { return scriptEvent; }
                set { scriptEvent = value; }
            }
            public int TextID {
                get { return textID; }
                set { textID = value; }
            }
            public int SentTestAction {
                get { return sentTestAction; }
                set { sentTestAction = value; }
            }
        }
        public class Type0
        {
            int tableID;
            int textID;
            int ammo;
            int ammoAUX;

            public int TableID {
                get { return tableID; }
                set { tableID = value; }
            }
            public int TextID {
                get { return textID; }
                set { textID = value; }
            }
            public int Ammo {
                get { return ammo; }
                set { ammo = value; }
            }
            public int AmmoAUX {
                get { return ammoAUX; }
                set { ammoAUX = value; }
            }
        }

        ActorItemFlags flags;
        int type;
        float respawnTime;
        int testPrimitive;
        float range;
        ItemScript scriptEvent;
        Type0 type0Data;
        Vector3 unk1;
        Vector3 unk2;

        public ActorItemFlags Flags {
            get { return flags; }
            set { flags = value; }
        }
        public int Type {
            get { return type; }
            set { type = value; }
        }
        public float RespawnTime {
            get { return respawnTime; }
            set { respawnTime = value; }
        }
        public int TestPrimitive {
            get { return testPrimitive; }
            set { testPrimitive = value; }
        }
        public float Range {
            get { return range; }
            set { range = value; }
        }
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public ItemScript ScriptEvent {
            get { return scriptEvent; }
            set { scriptEvent = value; }
        }
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Type0 Type0Data {
            get { return type0Data; }
            set { type0Data = value; }
        }
        [TypeConverter(typeof(Vector3Converter))]
        public Vector3 Unk1 {
            get { return unk1; }
            set { unk1 = value; }
        }
        [TypeConverter(typeof(Vector3Converter))]
        public Vector3 Unk2 {
            get { return unk2; }
            set { unk2 = value; }
        }

        public ActorItem(MemoryStream reader, bool isBigEndian)
        {
            ReadFromFile(reader, isBigEndian);
        }

        public int GetSize()
        {
            return 152;
        }

        public void ReadFromFile(MemoryStream reader, bool isBigEndian)
        {
            reader.ReadInt16(isBigEndian);
            flags = (ActorItemFlags)reader.ReadUInt16(isBigEndian);
            type = reader.ReadInt32(isBigEndian);
            respawnTime = reader.ReadSingle(isBigEndian);

            switch(type)
            {
                case 0:
                    type0Data = new Type0();
                    type0Data.TableID = reader.ReadInt32(isBigEndian);
                    type0Data.TextID = reader.ReadInt32(isBigEndian);
                    type0Data.Ammo = reader.ReadInt32(isBigEndian);
                    type0Data.AmmoAUX = reader.ReadInt32(isBigEndian);
                    reader.Seek(92, SeekOrigin.Current);
                    break;
                case 2:
                    scriptEvent = new ItemScript();
                    scriptEvent.TextID = reader.ReadInt32(isBigEndian);
                    scriptEvent.SentTestAction = reader.ReadInt32(isBigEndian);
                    reader.Seek(36, SeekOrigin.Current);
                    scriptEvent.ScriptEvent = reader.ReadStringBuffer(64).TrimEnd('\0');
                    break;
                case 3:
                    throw new Exception();
                    break;
                case 7:
                    throw new Exception();
                    break;
                case 8:
                    throw new Exception();
                    break;
                case 9:
                    reader.Seek(108, SeekOrigin.Current);
                    break;
                default:
                    throw new Exception();
                    break;
            }

            testPrimitive = reader.ReadInt32(isBigEndian);
            range = reader.ReadSingle(isBigEndian);
            unk1 = Vector3Extenders.ReadFromFile(reader, isBigEndian);
            unk2 = Vector3Extenders.ReadFromFile(reader, isBigEndian);
        }

        public void WriteToFile(MemoryStream writer, bool isBigEndian)
        {
            writer.Write((ushort)0, isBigEndian);
            writer.Write((ushort)flags, isBigEndian);
            writer.Write(type, isBigEndian);
            writer.Write(respawnTime, isBigEndian);

            switch (type)
            {
                case 0:
                    writer.Write(type0Data.TableID, isBigEndian);
                    writer.Write(type0Data.TextID, isBigEndian);
                    writer.Write(type0Data.Ammo, isBigEndian);
                    writer.Write(type0Data.AmmoAUX, isBigEndian);
                    writer.Write(new byte[92]);
                    break;
                case 2:
                    writer.Write(scriptEvent.TextID, isBigEndian);
                    writer.Write(scriptEvent.SentTestAction, isBigEndian);
                    writer.Write(new byte[36]);
                    writer.WriteStringBuffer(64, scriptEvent.ScriptEvent);
                    break;
                case 3:
                    throw new Exception();
                    break;
                case 7:
                    throw new Exception();
                    break;
                case 8:
                    throw new Exception();
                    break;
                case 9:
                    writer.Write(new byte[108]);
                    break;
                default:
                    throw new Exception();
                    break;
            }

            writer.Write(testPrimitive, isBigEndian);
            writer.Write(range, isBigEndian);
            Vector3Extenders.WriteToFile(unk1, writer, isBigEndian);
            Vector3Extenders.WriteToFile(unk2, writer, isBigEndian);
        }
    }

    public class ActorPinup : IActorExtraDataInterface
    {
        int pinupNum;

        public int PinupNum {
            get { return pinupNum; }
            set { pinupNum = value; }
        }

        public ActorPinup(MemoryStream stream, bool isBigEndian)
        {
            ReadFromFile(stream, isBigEndian);
        }

        public void ReadFromFile(MemoryStream stream, bool isBigEndian)
        {
            pinupNum = stream.ReadInt32(isBigEndian);
        }

        public void WriteToFile(MemoryStream stream, bool isBigEndian)
        {
            stream.Write(pinupNum, isBigEndian);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", ActorTypes.Pinup, pinupNum);
        }

        public int GetSize()
        {
            return 4;
        }
    }

    public class ActorScriptEntity : IActorExtraDataInterface
    {
        string scriptName;
        int unk01;

        public string ScriptName {
            get { return scriptName; }
            set { scriptName = value; }
        }
        public int Unk01 {
            get { return unk01; }
            set { unk01 = value; }
        }

        public ActorScriptEntity(MemoryStream stream, bool isBigEndian)
        {
            ReadFromFile(stream, isBigEndian);
        }

        public void ReadFromFile(MemoryStream stream, bool isBigEndian)
        {
            scriptName = stream.ReadStringBuffer(96).TrimEnd('\0');
            unk01 = stream.ReadInt32(isBigEndian);
        }

        public void WriteToFile(MemoryStream stream, bool isBigEndian)
        {
            stream.WriteStringBuffer(96, scriptName, '\0');
            stream.Write(unk01, isBigEndian);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", ActorTypes.ScriptEntity, scriptName);
        }

        public int GetSize()
        {
            return 100;
        }
    }
}
