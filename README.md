This is a very simple Bomberman clone!

USING FLATBUFFFERS

Flatbuffers are used to store colors for characters. You don't need to know much about them, except the following. 

They follow a schema defined in Flatbuffers/schema.fbs.

You can autogenerate C# files for the schema that will be loaded into Unity automatically. To do so, go to the Flatbuffers folder and run:

On Mac: ./flatc_osx --gen-all --csharp -o ../Assets/Scripts/Flatbuffers schema.fbs

On Windows, in GIT Bash: ./flatc --gen-all --csharp -o ../Assets/Scripts/Flatbuffers schema.fbs

Upon running these, C# files will automatically generated, and you can access the properties of Flatbuffer objects directly. Further specifics are alluded to in the Player.cs code.
