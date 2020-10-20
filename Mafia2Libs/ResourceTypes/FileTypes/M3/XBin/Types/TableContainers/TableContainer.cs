﻿using System;
using System.IO;
using System.Windows.Forms;

namespace ResourceTypes.M3.XBin.TableContainers
{
    public class TableContainer : BaseTable
    {
        public uint AIWeaponPtr { get; set; } // Not implemented in Toolkit.
        public uint AnimParticlesPtr { get; set; } // Not implemented in game.
        public uint AttackParamsPtr { get; set; } // Not implemented in game.
        public CarColoursTable CarColours { get; set; }
        public CarWindowTintTable CarWindowTints { get; set; }
        public uint CarInteriorColorsTableMPPtr { get; set; } // Not implemented in game.
        public uint CarGearboxesTableMPPtr { get; set; } // Not implemented in game.
        public CarMtrStuffTable CarMtrStuff { get; set; }
        public CarSkidmarksTable CarSkidmarks { get; set; }
        public CarTuningItemTable CarTuningItems { get; set; }
        public uint CarTuningModificatorsTableMPPtr { get; set; } // Not implemented in game.
        public uint CombinableCharactersTableMPPtr { get; set; } // Not implemented in game.
        public uint CrashObjectTablePtr { get; set; } // Not implemented in game.
        public uint CubeMapsTablePtr { get; set; } // Not implemented in game.
        public uint DamageMultiplierTablePtr { get; set; } // Not implemented in game.
        public uint FamilyAlbumExtrasTablePtr { get; set; } // Not implemented in game.
        public uint FamilyAlbumTablePtr { get; set; } // Not implemented in game.

        public void ReadFromFile(BinaryReader reader)
        {
            AIWeaponPtr = reader.ReadUInt32();
            AnimParticlesPtr = reader.ReadUInt32();
            AttackParamsPtr = reader.ReadUInt32();

            long currentPosition = reader.BaseStream.Position + 4;
            XBinCoreUtils.GotoPtrWithOffset(reader);
            CarColours = new CarColoursTable();
            CarColours.ReadFromFile(reader);

            reader.BaseStream.Seek(currentPosition, SeekOrigin.Begin);
            currentPosition = reader.BaseStream.Position + 4;
            XBinCoreUtils.GotoPtrWithOffset(reader);
            CarWindowTints = new CarWindowTintTable();
            CarWindowTints.ReadFromFile(reader);

            reader.BaseStream.Seek(currentPosition, SeekOrigin.Begin);
            CarInteriorColorsTableMPPtr = reader.ReadUInt32();
            CarGearboxesTableMPPtr = reader.ReadUInt32();

            currentPosition = reader.BaseStream.Position + 4;
            XBinCoreUtils.GotoPtrWithOffset(reader);
            CarMtrStuff = new CarMtrStuffTable();
            CarMtrStuff.ReadFromFile(reader);

            reader.BaseStream.Seek(currentPosition, SeekOrigin.Begin);
            currentPosition = reader.BaseStream.Position + 4;
            XBinCoreUtils.GotoPtrWithOffset(reader);
            CarSkidmarks = new CarSkidmarksTable();
            CarSkidmarks.ReadFromFile(reader);

            reader.BaseStream.Seek(currentPosition, SeekOrigin.Begin);
            currentPosition = reader.BaseStream.Position + 4;
            XBinCoreUtils.GotoPtrWithOffset(reader);
            CarTuningItems = new CarTuningItemTable();
            CarTuningItems.ReadFromFile(reader);

            CarTuningModificatorsTableMPPtr = reader.ReadUInt32();
            CombinableCharactersTableMPPtr = reader.ReadUInt32();
            CrashObjectTablePtr = reader.ReadUInt32();
            CubeMapsTablePtr = reader.ReadUInt32();
            DamageMultiplierTablePtr = reader.ReadUInt32();
            FamilyAlbumExtrasTablePtr = reader.ReadUInt32();
            FamilyAlbumTablePtr = reader.ReadUInt32();

            reader.BaseStream.Seek(currentPosition, SeekOrigin.Begin);
            currentPosition = reader.BaseStream.Position + 4;
            XBinCoreUtils.GotoPtrWithOffset(reader);
        }

        public void WriteToFile(XBinWriter writer)
        {
            throw new NotImplementedException();
        }

        public void ReadFromXML(string file)
        {
            throw new NotImplementedException();
        }

        public void WriteToXML(string file)
        {
            throw new NotImplementedException();
        }

        public TreeNode GetAsTreeNodes()
        {
            TreeNode Root = new TreeNode();
            Root.Text = "Table Container";
            Root.Nodes.Add(CarColours.GetAsTreeNodes());
            Root.Nodes.Add(CarWindowTints.GetAsTreeNodes());
            Root.Nodes.Add(CarMtrStuff.GetAsTreeNodes());
            Root.Nodes.Add(CarSkidmarks.GetAsTreeNodes());
            Root.Nodes.Add(CarTuningItems.GetAsTreeNodes());

            return Root;
        }

        public void SetFromTreeNodes(TreeNode Root)
        {
            throw new NotImplementedException();
        }

        private void GotoTablePtr(BinaryReader reader)
        {

        }
    }
}
