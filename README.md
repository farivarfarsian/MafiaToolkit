
# Mafia II: Toolkit

[![Build status](https://ci.appveyor.com/api/projects/status/62dtija7vekn7htn/branch/master?svg=true)](https://ci.appveyor.com/project/Greavesy1899/mafia2toolkit)

This toolkit is a group of programs which aims to achieve new type of mods and reversing the lesser known formats of this game.

## Features:
All features of the toolkit are heavily work in progress, and are constantly being improved to improve usability and mobility. The list below includes all the current features, which may or may not be complete. 

**Game Explorer**
Not the best feature in this toolkit, its primary reason it exists is because it makes it easier to load up different editors and manage SDS files. This feature needs serious improvements to usability however.

**SDS Packing/Repacking**
This feature uses Gibbed's SDS code from his [repository](https://github.com/gibbed/Gibbed.Illusion), with multiple fixes and improvements. XML files and the games tables are automatically decompiled, with the option to decompile the LUA files. There is an option to unpack SDS files in the format like "SDS Tools GUI", for the people who would like to open the contents in ZModeler3. For repacking, the modder can either choose compressed or uncompressed in the toolkits options. Double clicking any SDS in the game explorer will unpack, and to repack right click the SDS you unpacked, and click "pack".

**Map Editor**
The map editor is the main feature of the toolkit. The main objective is to allow modders to use this to edit maps, navigation, and animated objects. Currently, it has the ability to edit maps geometry and their collisions. More experimental features include "animal paths", road traffic, "actors" which are animated objects, and "translocators" which are instanced objects placed around the map. To load this up, double click on any "FrameResource_X.fr" file in any SDS.

**M2FBX**
This library is used alongside the map editor to allow modders to export/import Mafia II models, and the ability to "cook" the collision - improving ingame performance and stability. The library is under a heavy rework to allow the editing of skinned objects, and a general refactor of the code.

**Material Editor**
One of the earliest features implemented into the toolkit and one of the least updated features; but still has the ability to add/remove materials, add parameters or samplers to materials, and even merge to .MTL files giving the option to add new materials and overwrite existing ones. This editor can be loaded up by double click the ".MTL" files either generated by ZModeler3 or the "default_X.mtl".

**Translocator Editor**
A temporary editor whilst the map editor gets its much needed improvements. But gives the basic usability to add new objects and instances, and also delete them. You can load this editor by double clicking the "Translokator_X.tra" in the city_crash folder.

**Cityareas.bin/CityShops.bin Editor**
Both separate editors but achieve the same thing - add new city parts and shops into the map. To load up the "cityareas.bin" editor, double click it in the game explorer. Double clicking the "cityshops.bin" file  will open the editor for cityshops.

**Table Editor**
A basic table editor which allows modders to manipulate data and add new rows. 

## Building:
Only Windows is supported. Use Visual Studio 2019 to build the GitHub repository. 
For M2FBX, you'll need to have the Fbx SDK and PhysX 2.8.X to compile the solution.

## Known Bugs/Issues
You can check the current issues [here](https://github.com/Greavesy1899/Mafia2Toolkit/issues "Issues").

## Discord link:
To keep upto date on the progress of this toolkit, I recommend joining this discord by using the link [here](http://bit.ly/2L4z8vj "Discord invite")
