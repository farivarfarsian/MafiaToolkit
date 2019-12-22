﻿using System;
using SharpDX;

namespace Utils.Models
{
    public class VertexTranslator
    {
        /*
         * Position.X = 2 Bytes / Half;
         * Position.Y = 2 Bytes / Half;
         * Position.Z = 2 Bytes / Half;
         * Position.W = 2 Bytes / Half; 
         *  Also 
         *      Tangent.X = 1 Bytes (1st Bytes of Position.W)
         *      Tangent.Y = 1 Bytes (2nd Bytes of Position.W)
         * Normal.X = 1 Bytes / Byte.
         * Normal.Y = 1 Bytes / Byte.
         * Normal.Z = 1 Bytes / Byte.
         * Normal.W = 1 Bytes / Bytes.
         * 
         *  Also
         *      Tangent.W = 1 Bytes (1st Bytes of Normal.W)
         * 
         *
         * */
        public static Vector3 ReadPositionDataFromVB(byte[] data, int i, float factor, Vector3 offset)
        {
            Vector3 vec = new Vector3();
            ushort x = BitConverter.ToUInt16(data, i);
            ushort y = BitConverter.ToUInt16(data, i + 2);
            ushort z = (ushort)(BitConverter.ToUInt16(data, i + 4) & short.MaxValue);
            vec = new Vector3(x * factor, y * factor, z * factor);
            vec += offset;
            return vec;
        }

        public static Vector3 ReadTangentDataFromVB(byte[] data, int i)
        {
            Vector3 vec = new Vector3();
            float x = (data[i + 6] - 127.0f) * 0.007874f;
            float y = (data[i + 7] - 127.0f) * 0.007874f;
            float z = (data[i + 11] - 127.0f) * 0.007874f;
            vec = new Vector3(x, y, z);
            vec.Normalize();
            return vec;
        }

        public static Vector3 ReadNormalDataFromVB(byte[] data, int i)
        {
            Vector3 norm = new Vector3();
            float tx = (data[i] - 127.0f) * 0.007874f;
            float ty = (data[i + 1] - 127.0f) * 0.007874f;
            float tz = (data[i + 2] - 127.0f) * 0.007874f;
            norm.X = tx;
            norm.Y = ty;
            norm.Z = tz;
            norm.Normalize();

            //SharpDX.Half x = new SharpDX.Half(data[i]);
            //SharpDX.Half y = new SharpDX.Half(data[i + 1]);
            //SharpDX.Half z = new SharpDX.Half(data[i + 2]);
            //Vector3 vec = new Vector3();
            //vec.X = data[i];
            //vec.Y = data[i+1];
            //vec.Z = data[i+2];
            //vec /= 255;
            //vec = vec * 2 - 1;
            return norm;
        }

        public static Vector2 ReadTexcoordFromVB(byte[] data, int i)
        {
            System.Half x = System.Half.ToHalf(data, i);
            System.Half y = System.Half.ToHalf(data, i + 2);
            y = -y;
            return new Vector2(x, y);
        }

        public static int ReadDamageGroupFromVB(byte[] data, int i)
        {
            return BitConverter.ToInt32(data, i);
        }

        public static byte[] ReadColorFromVB(byte[] data, int i)
        {
            byte[] color = new byte[4];
            color[0] = data[i + 0];
            color[1] = data[i + 1];
            color[2] = data[i + 2];
            color[3] = data[i + 3];
            return color;
        }

        public static Vector3 ReadBBCoeffsVB(byte[] data, int i)
        {
            Vector3 vec = new Vector3();
            vec.X = BitConverter.ToSingle(data, i);
            vec.Y = BitConverter.ToSingle(data, i + 4);
            vec.Z = BitConverter.ToSingle(data, i + 8);
            return vec;
        }

        public static float[] ReadWeightsFromVB(byte[] data, int i)
        {
            float[] weights = new float[4];
            weights[0] = (data[i + 0] / 255.0f);
            weights[1] = (data[i + 1] / 255.0f);
            weights[2] = (data[i + 2] / 255.0f);
            weights[3] = (data[i + 3] / 255.0f);
            return weights;
        }

        public static byte[] ReadBonesFromVB(byte[] data, int i)
        {
            byte[] bones = new byte[4];
            Array.Copy(data, i, bones, 0, 4);
            return bones;
        }
    }
}
